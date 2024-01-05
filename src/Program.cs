using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123456", "Nokia 8", "IMEI123", 64);
Smartphone iphone = new Iphone("654321", "iPhone X", "IMEI456", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
