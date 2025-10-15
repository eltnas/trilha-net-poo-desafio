using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Objeto Nokia
Console.Clear();
Console.WriteLine("\n##########  Nokia  ##########\n");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

// Objeto Iphone
Console.WriteLine("\n##########  Iphone  ##########\n");
Smartphone iphone = new Iphone("987654321", "Iphone 13", "987654321098765", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");