void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  delay(50);
  Serial.print((int)random(16));
  Serial.print("/");
  Serial.print((int)random(16));
  Serial.print("/");
  Serial.print((int)random(16));
  Serial.print("/");
  Serial.print((int)random(16));
  Serial.print("/");
  Serial.print((int)random(16));
  Serial.println("");
}
