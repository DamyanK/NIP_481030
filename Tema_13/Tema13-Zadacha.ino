int redPin = 11;
int greenPin = 10;
int bluePin = 9;
  
void setup()
{
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);   
}

void loop()
{
  // RED, GREEN, BLUE  
  setColor(255, 0, 0);
  delay(1000);
  setColor(0, 255, 0);
  delay(1000);  
  setColor(0, 0, 255); 
  delay(1000);
  // CYAN, MAGENTA, YELLOW  
  setColor(0, 255, 255);  
  delay(1000);
  setColor(80, 0, 80);
  delay(1000);
  setColor(255, 255, 0);
  delay(1000);
}

void setColor(int red, int green, int blue)
{
  digitalWrite(redPin, red);
  digitalWrite(greenPin, green);
  digitalWrite(bluePin, blue);
}