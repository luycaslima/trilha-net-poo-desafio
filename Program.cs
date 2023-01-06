using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "123467", modelo: "Modelo 5200", imei: "22222222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.Write("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "54684970", modelo: "Pro", imei: "33333333333", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");