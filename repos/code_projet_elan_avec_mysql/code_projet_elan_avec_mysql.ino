#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
#include <mysql.h>

WiFiClient client;
ESP8266WiFiMulti WiFiMulti;

const int buttonPin = 12;
int buttonState = 0;
char *host = "sql9.freemysqlhosting.net", *user= "sql9325286", *pass= "gllCTD5exC", *db= "sql9325286";
int isconnected = 0;
bool connection;

void setup() {
    Serial.begin(115200);
    delay(100);
        WiFiMulti.addAP("Dandi", "80HBPiratespuB");
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
    delay(1000);
    
 /* isconnected = mysql_connect(host,user,pass,db);
  delay(1000);
  if(isconnected){
  }
  else{
    Serial.println("Connection failed.");
  }*/
}


void loop() {
  buttonState = digitalRead(buttonPin);
    if (buttonState == HIGH) {
    const uint16_t port = 1000;
    const char * hoster = "192.168.0.131"; // ip or dns        
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
}
