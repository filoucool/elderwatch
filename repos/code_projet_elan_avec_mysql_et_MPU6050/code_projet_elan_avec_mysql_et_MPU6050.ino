#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
#include <mysql.h>
#include <Wire.h>
#include <SPI.h>

WiFiClient client;
ESP8266WiFiMulti WiFiMulti;

const int buttonPin = 12; //D6
int buttonState = 0;
char *host = "sql9.freemysqlhosting.net", *user="sql9325286", *pass="gllCTD5exC", *db="sql9325286";
int isconnected = 0;
bool connection;

const int MPU_ADDR =      0x68; // MPU6050 (0x68)
const int WHO_AM_I =      0x75; // identification du dispositif
const int PWR_MGMT_1 =    0x6B; // registre de configuration de puissance
const int GYRO_CONFIG =   0x1B; // registre de configuration du giroscope
const int ACCEL_CONFIG =  0x1C; // registre de configuration de l'accelerometre
const int ACCEL_XOUT =    0x3B; // registre de lecture X de l'accelerometre int16_t AcX,AcY,AcZ,Tmp,GyX,GyY,GyZ;
float ax=0, ay=0, az=0, gx=0, gy=0, gz=0;
int16_t AcX, AcY, AcZ, Tmp, GyX, GyY, GyZ; 
const int sda_pin = 4; //SDA pin
const int scl_pin = 5; //scl pin
boolean fall = false; //stores if a fall has occurred
boolean trigger1=false; //stores if first trigger (lower threshold) has occurred
boolean trigger2=false; //stores if second trigger (upper threshold) has occurred
boolean trigger3=false; //stores if third trigger (orientation change) has occurred
byte trigger1count=0; //stores the counts past since trigger 1 was set true
byte trigger2count=0; //stores the counts past since trigger 2 was set true
byte trigger3count=0; //stores the counts past since trigger 3 was set true
int angleChange=0;

char BouttonUrgence;
char Chute;

void setup() {

  //wifi connect
    Serial.begin(115200);
    delay(10);
    WiFiMulti.addAP("DataTSO_momo", "lolaflorez&");
      //  WiFiMulti.addAP("Dandi", "80HBPiratespuB");

    Serial.println();
    Serial.println();
    Serial.print("Wait for WiFi... ");

    while(WiFiMulti.run() != WL_CONNECTED) {
        Serial.print(".");
        delay(500);
    }
    Serial.println("");
    Serial.println("WiFi connected");
    Serial.println("IP address: ");
    Serial.println(WiFi.localIP());
    delay(500);

   //MYSQL connect
  isconnected = mysql_connect(host,user,pass,db);
  if(isconnected){
    Serial.print("Connected to ");
                Serial.println(host);
  }
  else{
    Serial.println("Connection failed.");
  }

//MPU6050

 Wire.begin();
 Wire.beginTransmission(MPU_ADDR);
 Wire.write(0x6B);  // PWR_MGMT_1 register
 Wire.write(0);     // set to zero (wakes up the MPU-6050)
 Wire.endTransmission(true);
 pinMode(11, OUTPUT);
 digitalWrite(11, HIGH);
 
   initI2C();
   initMPU();
  checkMPU(MPU_ADDR);

}


void loop() {
  //EMERGENCY BUTTON
  buttonState = digitalRead(buttonPin);
    if (buttonState == HIGH) {
   SendToHost(BouttonUrgence);
}

mpu_read();
triggerverif();
}


void triggerverif(){
 //2050, 77, 1947 are values for calibration of accelerometer
 // values may be different for you
 ax = (AcX-2050)/16384.00;
 ay = (AcY-77)/16384.00;//
 az = (AcZ-1947)/16384.00;

 //270, 351, 136 for gyroscope
 gx = (GyX+270)/131.07;
 gy = (GyY-351)/131.07;
 gz = (GyZ+136)/131.07;

 // calculating Amplitute vactor for 3 axis
 float Raw_AM = pow(pow(ax,2)+pow(ay,2)+pow(az,2),0.5);
 int AM = Raw_AM * 10;  // as values are within 0 to 1, I multiplied 
                        // it by for using if else conditions 

 Serial.println(AM);
 //Serial.println(PM);
 //delay(500);

 if (trigger3==true){
    trigger3count++;
    //Serial.println(trigger3count);
    if (trigger3count>=10){ 
       angleChange = pow(pow(gx,2)+pow(gy,2)+pow(gz,2),0.5);
       //delay(10);
       Serial.println(angleChange); 
       if ((angleChange>=0) && (angleChange<=10)){ //if orientation changes remains between 0-10 degrees
           fall=true; trigger3=false; trigger3count=0;
           Serial.println(angleChange);
             }
       else{ //user regained normal orientation
          trigger3=false; trigger3count=0;
          Serial.println("TRIGGER 3 DEACTIVATED");
       }
     }
  }
 if (fall==true){ //in event of a fall detection
   Serial.println("FALL DETECTED");
   digitalWrite(11, LOW);
   delay(20);
   digitalWrite(11, HIGH);
   fall=false;
  // exit(1);
   }
 if (trigger2count>=6){ //allow 0.5s for orientation change
   trigger2=false; trigger2count=0;
   Serial.println("TRIGGER 2 DECACTIVATED");
   }
 if (trigger1count>=6){ //allow 0.5s for AM to break upper threshold
   trigger1=false; trigger1count=0;
   Serial.println("TRIGGER 1 DECACTIVATED");
   }
 if (trigger2==true){
   trigger2count++;
   //angleChange=acos(((double)x*(double)bx+(double)y*(double)by+(double)z*(double)bz)/(double)AM/(double)BM);
   angleChange = pow(pow(gx,2)+pow(gy,2)+pow(gz,2),0.5); Serial.println(angleChange);
   if (angleChange>=30 && angleChange<=400){ //if orientation changes by between 80-100 degrees
     trigger3=true; trigger2=false; trigger2count=0;
     Serial.println(angleChange);
     Serial.println("TRIGGER 3 ACTIVATED");
       }
   }
 if (trigger1==true){
   trigger1count++;
   if (AM>=12){ //if AM breaks upper threshold (3g)
     trigger2=true;
     Serial.println("TRIGGER 2 ACTIVATED");
     trigger1=false; trigger1count=0;
     }
   }
 if (AM<=2 && trigger2==false){ //if AM breaks lower threshold (0.4g)
   trigger1=true;
   Serial.println("TRIGGER 1 ACTIVATED");
   }
//It appears that delay is needed in order not to clog the port
 delay(100);
}



//COMMUNICATES WITH THE COMPUTER
void SendToHost(char problem){
   const uint16_t port = 1000;
    const char * hoster = "192.168.0.132"; // ip or dns        
    Serial.print("connecting to ");
    Serial.println(hoster);

    WiFiClient client;

    if (!client.connect(hoster, port)) {
        Serial.println("connection failed");
        delay(1000);
        return;
    }
    client.print("*/NAME* a besoin d'aide! (Ard 1)");
    String line = client.readStringUntil('\r');
    client.println(line);
    Serial.println("closing connection");
    client.stop();
    delay(1000);
  }


//READS THE DATA FROM THE MCU6050
void mpu_read(){
 Wire.write(0x3B);  // starting with register 0x3B (ACCEL_XOUT_H)
 Wire.endTransmission(false);
 Wire.requestFrom(MPU_ADDR,14,true);  // request a total of 14 registers
 AcX=Wire.read()<<8|Wire.read();  // 0x3B (ACCEL_XOUT_H) & 0x3C (ACCEL_XOUT_L)    
 AcY=Wire.read()<<8|Wire.read();  // 0x3D (ACCEL_YOUT_H) & 0x3E (ACCEL_YOUT_L)
 AcZ=Wire.read()<<8|Wire.read();  // 0x3F (ACCEL_ZOUT_H) & 0x40 (ACCEL_ZOUT_L)
 Tmp=Wire.read()<<8|Wire.read();  // 0x41 (TEMP_OUT_H) & 0x42 (TEMP_OUT_L)
 GyX=Wire.read()<<8|Wire.read();  // 0x43 (GYRO_XOUT_H) & 0x44 (GYRO_XOUT_L)
 GyY=Wire.read()<<8|Wire.read();  // 0x45 (GYRO_YOUT_H) & 0x46 (GYRO_YOUT_L)
 GyZ=Wire.read()<<8|Wire.read();  // 0x47 (GYRO_ZOUT_H) & 0x48 (GYRO_ZOUT_L)
 }

 void initI2C() 
{
  Wire.begin(sda_pin, scl_pin);
}

void writeRegMPU(int reg, int val)      
{
  Wire.beginTransmission(MPU_ADDR);     // commence la communication avec le mpu6050
  Wire.write(reg);                      
  Wire.write(val);                      
  Wire.endTransmission(true);           // ferme la transmission
}

uint8_t readRegMPU(uint8_t reg)        
{
  uint8_t data;
  Wire.beginTransmission(MPU_ADDR);     // commence la communication avec le MPU6050
  Wire.write(reg);                       
  Wire.endTransmission(false);          
  Wire.requestFrom(MPU_ADDR, 1);        
  data = Wire.read();                   
  return data;                          //return 'data'
}

void findMPU(int MPU_ADDR)
{
  Wire.beginTransmission(MPU_ADDR);
  int data = Wire.endTransmission(true);
 
  if(data == 0)
  {
    Serial.print("device found at address: 0x");
    Serial.println(MPU_ADDR, HEX);
  }
  else
  {
    Serial.println("Device not found!");
  }
}

void checkMPU(int MPU_ADDR)
{
  findMPU(MPU_ADDR);
     
  int data = readRegMPU(WHO_AM_I); // Register 117 – Who Am I - 0x75
   
  if(data == 104) 
  {
    Serial.println("MPU6050 response =  OK! (104)");
 
    data = readRegMPU(PWR_MGMT_1); // Register 107 – Power Management 1-0x6B
 
    if(data == 64) Serial.println("MPU6050 is SLEEPING! (64)");
    else Serial.println("MPU6050 ACTIVE!"); 
  }
  else Serial.println("VÉRIFICATION - MPU6050 NON  DISPONIBLE!");
}

void initMPU()
{
  setSleepOff();
  setGyroScale();
  setAccelScale();
}
 

void setSleepOff()
{
  writeRegMPU(PWR_MGMT_1, 0); 
}

void setGyroScale()
{
  writeRegMPU(GYRO_CONFIG, 0);
}
 

void setAccelScale()
{
  writeRegMPU(ACCEL_CONFIG, 0);
}
 

void readRawMPU()
{  
  Wire.beginTransmission(MPU_ADDR);       // commence la communication avec le mpu6050
  Wire.write(ACCEL_XOUT);                      
                                    
}
