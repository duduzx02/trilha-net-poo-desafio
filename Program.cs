using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone nokia");
Smartphone iphone = new Iphone("123456789", "Iphone 13", "123456789", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");