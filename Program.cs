using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("1234567", "Nokia 1010", "Imei 12345", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatapps");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone("1234567", "Iphone 13", "Imei 12345", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");




