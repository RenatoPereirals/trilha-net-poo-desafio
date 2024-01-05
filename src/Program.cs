using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new("123456", "Nokia 8", "IMEI123", 64);
Iphone iphone = new("654321", "iPhone X", "IMEI456", 128);

Smartphone.Ligar();
Smartphone.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Smartphone.Ligar();
Smartphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
