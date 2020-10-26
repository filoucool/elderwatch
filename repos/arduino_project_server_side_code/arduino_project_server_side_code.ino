int minD;
int noD = 20; //number of devices

String inputString = "";         // a string to hold incoming data
boolean stringComplete = false;  // whether the string is complete
String commandString = "";

boolean isConnected = false;

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println("hi");

if(stringComplete)
{
  stringComplete = false;
  getCommand();
  
  if(commandString.equals("STAR"))
  {
    //new connections, clears all
  }
  if(commandString.equals("STOP"))
  {
    //stop all   
  }
  else if(commandString.equals("Check"))
  {
   check(); //check method
  }
    else if(commandString.equals("CheckAll"))
  {
    checkall(); //check aLL method  
  }
    else if(commandString.equals("Call"))
  {
    call(); //call method
  }
   else if(commandString.equals("CallAll"))
  {
    callall(); //call All method
  }
  
  inputString = "";
}

}

void check(){
  
  }
void checkall(){
  
  }
void call(){
  
  }
void callall(){
  
  }
  
void getCommand()
{
  if(inputString.length()>0)
  {
     commandString = inputString.substring(1,5);
  }
}
  
  void serialEvent() {
  while (Serial.available()) {
    // get a new byte
    char inChar = (char)Serial.read();
    // add to inputString:
    inputString += inChar;
    // if newline, set flag
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
