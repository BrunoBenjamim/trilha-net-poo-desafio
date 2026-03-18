using DesafioPOO.Models;

Console.WriteLine("");
Console.WriteLine("------------------------------");
Console.WriteLine("SMARTPHONE NOKIA");
Smartphone nokia = new Nokia("1234", "1111", "2222", 50);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WHATSAPP");

Console.WriteLine("");
Console.WriteLine("------------------------------");
Console.WriteLine("SMARTPHONE IPHONE");
Smartphone iphone = new Iphone("2345", "3333", "4444", 85);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("UBER");
Console.WriteLine("");

