
#include <mysql.h>



char *host, *user, *pass, *db;
int isconnected = 0;

void setup()
{
    Serial.begin(115200);
  
	host = "sql9.freemysqlhosting.net";
	user = "sql9325286";
	pass = "gllCTD5exC";
	db = "sql9325286";
	isconnected = mysql_connect(host,user,pass,db);
	if(isconnected){
		Serial.print("Connected to ");
                Serial.println(host);
	}
	else{
		Serial.println("Connection failed.");
	}
	mysql_close();
}

void loop()
{
  }
