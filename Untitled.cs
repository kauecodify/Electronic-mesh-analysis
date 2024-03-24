// Declaração do pino onde o LED está conectado
const int ledPin = 13;

// Função de inicialização do Arduino
void setup() {
  // Configura o pino do LED como saída
  pinMode(ledPin, OUTPUT);
}

// Função principal do Arduino
void loop() {
  // Liga o LED
  digitalWrite(ledPin, HIGH);
  
  // Espera por um segundo
  delay(1000);
  
  // Desliga o LED
  digitalWrite(ledPin, LOW);
  
  // Espera por um segundo
  delay(1000);
}