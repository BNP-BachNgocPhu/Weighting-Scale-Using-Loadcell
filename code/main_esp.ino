#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <EEPROM.h>
#include <math.h>
#define FLASH_MEMORY_SIZE 512
double zerotime =0;
double spantime =0;
double zero;
double span; 
const int LEDPIN = 14; 
const int BUZZER = 12;
const int LOADCELL_DOUT_PIN = 4;
int t=100;

LiquidCrystal_I2C lcd(0x27,16,2);

double weightFilt =0;
double weightfiltPre =0;

void blinkledandplaybuzzer()
{
  digitalWrite(LEDPIN,HIGH);
  digitalWrite(BUZZER,HIGH);
  delay(500);
  digitalWrite(LEDPIN,LOW);
  delay(500);
  digitalWrite(LEDPIN,HIGH);
  delay(500);
  digitalWrite(LEDPIN,LOW);
  digitalWrite(BUZZER,LOW);
}

void setup() {
  Serial.begin(115200);
  pinMode(21, OUTPUT);
  pinMode(22, OUTPUT);
  lcd.init(); // initialize the lcd
  lcd.backlight();

  EEPROM.begin(FLASH_MEMORY_SIZE);
  pinMode(LEDPIN, OUTPUT);
  pinMode(BUZZER, OUTPUT); 
  digitalWrite(LEDPIN,LOW);
  digitalWrite(BUZZER,LOW);
  zero = EEPROM.read(0);
  span = EEPROM.read(8);
  //Print 
  lcd.setCursor(0, 0);  
          lcd.print("LOADCELL");
          lcd.setCursor(0, 1);  
          lcd.print("      UA741     ");  
          delay(1500);
          lcd.clear();

          lcd.setCursor(0, 0);  
          lcd.print("Designed by:     ");
          delay(800);
          lcd.clear();
   
           lcd.setCursor(0, 0);lcd.print("  B             ");delay(t);
           lcd.setCursor(0, 0);lcd.print("  BA            ");delay(t);         
           lcd.setCursor(0, 0);lcd.print("  BAC           ");delay(t);
           lcd.setCursor(0, 0);lcd.print("  BACH          ");delay(t);
           lcd.setCursor(0, 0);lcd.print("  BACH N        ");delay(t);
           lcd.setCursor(0, 0);lcd.print("  BACH NG       ");delay(t);
           lcd.setCursor(0, 0);lcd.print("  BACH NGO      ");delay(t);
           lcd.setCursor(0, 0);lcd.print("  BACH NGOC     ");delay(t);                                                  
           lcd.setCursor(0, 0);lcd.print("  BACH NGOC P   ");delay(t);          
           lcd.setCursor(0, 0);lcd.print("  BACH NGOC PH  ");delay(t); 
           lcd.setCursor(0, 0);lcd.print("  BACH NGOC PHU  ");delay(t);
           delay(1500);
           lcd.clear();

}

void loop() {
  //receiver data
  String dulieu = "";
  while(Serial.available()>0){
    char c = Serial.read();
    dulieu += c;
    delay(5);
  }

  dulieu.trim();
  String command = dulieu.substring(0,5);
  String data = dulieu.substring(5);

  if(command == "CALIB"){
  digitalWrite(LEDPIN, HIGH);
  blinkledandplaybuzzer();
  }

  if(command == "RESET"){
    digitalWrite(LEDPIN, LOW);
    blinkledandplaybuzzer();
    zerotime = 0;
    spantime = 0;
    int address = 0;
    EEPROM.writeDouble(address, zerotime);
    EEPROM.commit();
    address = 8;
    EEPROM.writeDouble(address, spantime);
    EEPROM.commit();
  }

  if(command == "CZERO"){
    blinkledandplaybuzzer();
    int address = 0;
    EEPROM.writeDouble(address, zerotime);
    EEPROM.commit();
    zerotime = data.toDouble();
    zero = zerotime;
  }

    if(command == "CSPAN"){
    blinkledandplaybuzzer();
    int address = 8;
    EEPROM.writeDouble(address, spantime);
    EEPROM.commit();
    spantime = data.toDouble();
    span = spantime;
  }
    
    double reading = analogRead(LOADCELL_DOUT_PIN);
    weightFilt = 0.854*weightFilt + 0.0728*reading + 0.0728*weightfiltPre;
    weightfiltPre = reading;
    Serial.println(weightFilt);

    lcd.setCursor(0, 0);  
    lcd.print("  CAN DIEN TU  ");
    lcd.setCursor(11, 1);  
    lcd.print("KG");  
    lcd.setCursor(3, 1);  
    lcd.print((weightfiltPre-zero)/span);
  // print message

   delay(100);
}