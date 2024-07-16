
// Pin assignments.
#define encoderA 2
#define encoderB 3
#define upperLimitSwitch 23
#define homeLimitSwitch 25
#define relayForward 29
#define relayBackward 31
#define relayBrake 35
#define Pwm 45
int m_sp = 50;
float ans;

volatile double counter = 0; 
unsigned long clock = 0;
volatile int aState;
volatile int aLastState;  
volatile int lastcounter = 0;

// variable to only read the weight from the rs232 communication.
int charcount = 1; 
bool stringComplete = false;
String stringweight = "";
float floatweight = 0.0;

// variable for dramatic load relase.
float previousWeight = 0.0;
float threshold = 2.5;
bool broken = false;
bool brokenloop = false;

// remove the extra space form the rs232 reading
String removeSpaces(String str) {
  String result = "";
  
  for (int i = 0; i < str.length(); i++) {
    if (str.charAt(i) != ' ') {
      result += str.charAt(i); 
    }
  }
  return result;
}

// encoder reading
void encoder()
{
  aState = digitalRead(encoderA);
   if (aState != aLastState){     
     if (digitalRead(encoderB) != aState) { 
       counter ++;
     } else {
       counter --;
     }
   } 
   aLastState = aState;
  lastcounter = counter;
}

void setup() {
  
  
  Serial.begin(115200); //Serial Communicaiton Begin
  Serial1.begin(9600); // Serial Communication for weighing machine
  // Motor pins
  pinMode(relayForward, OUTPUT);
  pinMode(relayBackward, OUTPUT);
  pinMode(relayBrake, OUTPUT);
  pinMode(Pwm, OUTPUT);

  // Limit switches
  pinMode(homeLimitSwitch, INPUT);
  pinMode(upperLimitSwitch, INPUT);

  // Encoder Pins
  pinMode (encoderA,INPUT_PULLUP);
  pinMode (encoderB,INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(encoderA),encoder,CHANGE);
  
  // Initialize relays to off position
  digitalWrite(relayForward, LOW);
  digitalWrite(relayBackward, LOW);
  digitalWrite(relayBrake, HIGH); // Engage brake initially
  delay(1000); // act as a loading bar 
}

void loop() {
  if (Serial.available()) {
    char command = Serial.read();
    switch (command) {
      case 'h': // Homing
        homingSequence();
        break;
      case 's': // Start motor forward and read load
        startMotorForward();
        break;
      case 'u': // jog up
        while(true)
        {
          int speed = Serial.parseInt();
          if ( speed != 0)
          {
            jog('u',speed);
            break;
          }
        }
        break;
      case 'd': // jog down
         while(true)
        {
          int speed = Serial.parseInt();
          if ( speed != 0)
          {
            jog('d',speed);
            break;
          }
        }
        break;
    }
  }
}

void homingSequence() {
  // Disengage brake and move motor backward
  if ( digitalRead(homeLimitSwitch) == LOW ){ // Check already Home
      CW(50);
     while (digitalRead(homeLimitSwitch) == LOW) 
     {
      // Wait until home limit switch is triggered
        yield();// ESP8266 can run background task
     }
  // Stop motor and engage brake
  stopMotor();
  Serial.println("homed");
  }
  counter = 0;
}

void startMotorForward() {
  bool broken = false;
  bool brokenloop = false;
  counter = 0;
  // Disengage brake and move motor forward
  CCW(m_sp);
  while (true) 
  {
    float encoderValue = (12.00/668.00)*counter;  // convert encoder reading into actual measurment
    if (Serial1.available()) 
    { 
      if (brokenloop == false){
      char inByte = Serial1.read();
      charcount ++;
       
       if(inByte == 'g')
       {
        charcount = 1;
       }
       else if(charcount >= 10)
       {
        //Serial.print(inByte);
        String stu = String(inByte);
        if (inByte == 'k') { // Check if the incoming character is 'g'
          stringComplete = true;  // Set the flag to true indicating the string is complete
        } else {
          stringweight += inByte; // Append the character to the string
        }
        }
         if (stringComplete) {
          // The incoming string is complete, process it here
          //floatweight = stringweight.toFloat();
          floatweight = removeSpaces(stringweight).toFloat();
          // Clear the string for the next round and reset the flag
          stringweight = "";
          stringComplete = false;


          if (( previousWeight - floatweight ) > 0 && floatweight < -0.01){
          brokenloop = true;
          }
          // Code to stop the machine or halt further readings
          
          previousWeight = floatweight; // Update the previousWeight with the current reading for the next comparison
        
        }
  
  }
    }
    if (clock >= 200)
    {
      //if (encoderValue>0)
      //{
        noInterrupts();
      Serial.print(encoderValue);
      Serial.print(",");
      Serial.println(floatweight);
        interrupts();
      //}
    
    }
    
    clock ++;
    if (digitalRead(upperLimitSwitch) == HIGH || brokenloop == true) {
      // Stop everything if upper limit switch is triggered or load falls dramatically
      stopMotor();
      break;
    }
    
  }
  delay(50);
}
void jog(char dirt,int dta)
{
  if (dirt == 'u')
  {
    CCW(10);
    delay(dta);
    stopMotor();
  }
  else if(dirt == 'd')
  {
    CW(10);
    delay(dta);
    stopMotor();
  }

}
void stopMotor() {
  digitalWrite(relayForward, LOW);
  digitalWrite(relayBackward, LOW);
  digitalWrite(relayBrake, HIGH); // Engage brake
}
void CW(int dta) {
  float hz = map (dta,0,50,0,255);
  analogWrite(Pwm,hz);
  digitalWrite(relayForward, HIGH);
  digitalWrite(relayBackward, LOW);
  digitalWrite(relayBrake, LOW); // Relase brake
}
void CCW(int dta) {
  float hz = map (dta,0,50,0,255);
  analogWrite(Pwm,hz);
  digitalWrite(relayForward, LOW);
  digitalWrite(relayBackward, HIGH);
  digitalWrite(relayBrake, LOW); // Relase brake
}

