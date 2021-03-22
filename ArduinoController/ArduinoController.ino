int pinPrueba = 7;
boolean stringComplete = false;
String commandString = "";
String inputString = "";
void setup() {
  Serial.begin(9600);
  pinMode(pinPrueba, OUTPUT);
}

void loop() {
  //serialEvent();
  if (stringComplete)
  {
    stringComplete = false;
    getCommand();

    if (commandString.equals("ON11"))
    {
      Serial.print("prender luz");
      TurnOnLight(pinPrueba);
    }

    if (commandString.equals("OF11"))
    {
      Serial.print("apagar luz");
      TurnOffLight(pinPrueba);
    }
    inputString = "";
  }
}

void TurnOnLight(int pin) {
  Serial.print("prendió luz");
  digitalWrite(pin, HIGH);
}

void TurnOffLight(int pin) {
  Serial.print("apagó luz");
  digitalWrite(pin, LOW);
}

void getCommand()
{
  //Edificio:
  //Depto: 1
  //Taller: 2

  //#ON<edificio><luz>\n encender una luz

  if (inputString.length() > 0)
  {
    commandString = inputString.substring(1, 5);
  }
  Serial.print("comando: " + commandString);
}

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputString += inChar;
    //Serial.print("leyó OF11");
    //inputString = "#OF11\n";
    // if the incoming character is a newline, set a flag
    // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}
