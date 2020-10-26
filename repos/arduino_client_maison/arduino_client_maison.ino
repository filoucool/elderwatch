#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
ESP8266WiFiMulti WiFiMulti;
const int buttonPin = 12;
int buttonState = 0;
const uint16_t port = 1000;
const char * host = "192.168.0.131";
WiFiClient client;
bool connection;

void setup() {
    Serial.begin(115200);
    delay(10);
    pinMode(buttonPin, INPUT);
    WiFiMulti.addAP("DataTSO_momo", "lolaflorez&");
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
    connection = true;
    delay(500);
}    

void loop() {
  if (connection == false){
    Serial.print("connecting to ");
    Serial.println(host);
    connection = true;
    if (!client.connect(host, port)) {
        Serial.println("connection failed");
        Serial.println("wait 5 sec...");
        delay(5000);
        return;
    }
    }
    buttonState = digitalRead(buttonPin);
    if (buttonState == HIGH) {
    client.print("*/NAME* a besoin d'aide! (Ard 9)");
    delay(500);
    }
   
    }
   
     
