#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
ESP8266WiFiMulti WiFiMulti;
const int buttonPin = 12;
int buttonState = 0;

WiFiClient client;
bool connection;

void setup() {
    Serial.begin(115200);
    delay(10);
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
    delay(500);
}


void loop() {
  buttonState = digitalRead(buttonPin);
    if (buttonState == HIGH) {
    const uint16_t port = 1000;
    const char * host = "192.168.0.160"; // ip or dns        
    Serial.print("connecting to ");
    Serial.println(host);

    WiFiClient client;

    if (!client.connect(host, port)) {
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
