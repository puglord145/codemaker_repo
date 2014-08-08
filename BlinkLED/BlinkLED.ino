//program light on
//turns light on
//gus gunter

//variables
boolean isOn = false;
int ledPinNumber = 9;
int delayLength = 100;
void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(ledPinNumber,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly: 
 digitalWrite(ledPinNumber,HIGH);
 delay(delayLength);
digitalWrite (ledPinNumber,LOW);
delay(delayLength);
}
