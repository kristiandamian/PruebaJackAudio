/*
 Botonera V1.0
 Botonera V1.1 24 de junio de 2015 20:26 hrs
 junio 2015
 Por Edgar Chucuan <http://www.telecomando.mx>
 
*/


const int botonPinA = 2; 
const int botonPinB = 4;
const int relayPin =  12;  
int botonA = 0;    
int botonB = 0;

void setup() {
  // Inicializa el pin del relay 01
  pinMode(relayPin, OUTPUT);      
  // Inicializa el pin del botón 01
  pinMode(botonPinA, INPUT); 
  pinMode(botonPinB, INPUT);   
}

void loop(){
  // Lees si el Pin del botón está activo:
  botonA = digitalRead(botonPinA);
  // Verifica si el botónA es presionado.
  // Si lo presionas el estado del Pin es HIGH
  if (botonA == HIGH){
    // Envia un solo clic:    
    digitalWrite(relayPin, HIGH);
    delay(100);
    digitalWrite(relayPin, LOW);

    //digitalWrite(relayPin, HIGH);
    //delay(100);
    //digitalWrite(relayPin, LOW);
  }
  else{
    digitalWrite(relayPin, LOW);
  }
  botonB = digitalRead(botonPinB);
  if (botonB == HIGH){
    // Envia un doble clic:
    digitalWrite(relayPin, HIGH);
    delay(100);
    digitalWrite(relayPin, LOW);
    delay(100);

    digitalWrite(relayPin, HIGH);
    delay(100);
    digitalWrite(relayPin, LOW);
    delay(100);

    digitalWrite(relayPin, HIGH);
    delay(100);
    digitalWrite(relayPin, LOW);
    delay(100);

    digitalWrite(relayPin, HIGH);
    delay(100);
    digitalWrite(relayPin, LOW);
    delay(100);

  }
  else{
    digitalWrite(relayPin, LOW);
  }
}
