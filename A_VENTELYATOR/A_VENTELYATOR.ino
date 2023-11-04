#include <ArduinoJson.h>
#include <EEPROM.h>
//#include <Wire.h> 
//#include <LiquidCrystal_I2C.h>
//#include <LCD_1602_RUS.h>

int L = 5;
int L_perc = 10; // start val
int L_perc_min = 46; //47 from stop
int R = 6;
int R_perc = 10; // start val
int R_perc_min = 54; //69 from stop //min val to move

const int JSON_BUFFER_SIZE = 256;
String PROJ_CODE = "ventelyator";

void SetPerc()
{
  EEPROM.put(0, L_perc);
  EEPROM.put(sizeof(int), R_perc);
}

void GetPerc()
{
  EEPROM.get(0, L_perc);
  EEPROM.get(sizeof(int), R_perc);
}

int calculatePWM(int percentage, int minimumPWM = 0) // 0-15 реакции нет, для этого
{
  if(percentage == 0) { return 0; }
  int maximumPWM = 255;
  percentage = constrain(percentage, 0, 100);
  int pwmValue = map(percentage, 0, 100, minimumPWM, maximumPWM);
  return pwmValue;
}

void PrintErrorJson(String error_msg)
{
   DynamicJsonDocument responseDoc(JSON_BUFFER_SIZE);
   responseDoc["error"] = error_msg;
   serializeJson(responseDoc, Serial);
   Serial.println();
}

void PrintDataJson(String message)
{
   DynamicJsonDocument responseDoc(JSON_BUFFER_SIZE);
   responseDoc["data"] = message;
   serializeJson(responseDoc, Serial);
   Serial.println();
}

bool IsValidAnalogVal(int value){ return (value >= 0 && value <= 255); }

int GetVent(String str)
{
   str.trim();
   //str.toLowerCase();
   str.toUpperCase();
   if(str == "L"){ return 1; }
   else if(str == "R"){ return 2; }
   else { return str.toInt(); }
}


void setup()
{
  Serial.begin(9600);
  pinMode(L, OUTPUT);
  pinMode(R, OUTPUT);
  GetPerc();
  analogWrite(L, calculatePWM(L_perc, L_perc_min));
  analogWrite(R, calculatePWM(R_perc, R_perc_min));
}


void loop()
{
  if (Serial.available())
  {
    String inputString = Serial.readStringUntil('\n');

    // Попытка разобрать JSON
    DynamicJsonDocument jsonDoc(JSON_BUFFER_SIZE);
    DeserializationError error = deserializeJson(jsonDoc, inputString);

    if (!error)
    {
      if (jsonDoc.containsKey("mode"))
      {
        String mode = jsonDoc["mode"].as<String>();
        mode.toLowerCase();


        if(mode == "set_val" && jsonDoc.containsKey("vent") && jsonDoc.containsKey("value"))
        {
          String _vent = jsonDoc["vent"].as<String>();
          String _value = jsonDoc["value"].as<String>();
          int value = _value.toInt();
          if (IsValidAnalogVal(value))
          {
            int vent = GetVent(_vent);
            if (vent == 1)
            { 
              L_perc = value;
              analogWrite(L, calculatePWM(value, L_perc_min)); SetPerc();
              PrintDataJson("OK");
            }
            else if (vent == 2)
            {
              R_perc = value;
              analogWrite(R, calculatePWM(value, R_perc_min)); SetPerc();
              PrintDataJson("OK");
            }
            else { PrintErrorJson("ERROR! VENT NOT FOUND!"); }
          }
          else { PrintErrorJson("ERROR! VALUE NOT VALID!"); }
        }



        else if(mode == "get_val")
        {
          if(jsonDoc.containsKey("vent"))
          {
            int vent = GetVent(jsonDoc["vent"].as<String>());
            if (vent == 1) { PrintDataJson(String(L_perc)); } // {"data":"50"}
            else if (vent == 2) { PrintDataJson(String(R_perc)); }
            else { PrintErrorJson("ERROR! VENT NOT FOUND!"); }
          }
          else
          {
            DynamicJsonDocument responseDoc(JSON_BUFFER_SIZE);
            responseDoc["1"] = String(L_perc); // {"1":"50", "2": "100"}
            responseDoc["2"] = String(R_perc);
            serializeJson(responseDoc, Serial);
            Serial.println();
          }
        }


        
        //else if (jsonDoc["mode"] == "hello") { PrintDataJson(PROJ_CODE); }
        else if (mode == "hello") { PrintDataJson(PROJ_CODE); }
        
        else { PrintErrorJson("ERROR! Cant find mode"); }
      }
      else { PrintErrorJson("ERROR! Cant find key mode"); }
      
    }
    
    else if (inputString == "hello") { PrintDataJson(PROJ_CODE); }
    else { PrintErrorJson("Error Deserealization"); }
    
  }
}
