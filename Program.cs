using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e 
Console.WriteLine("Smartphome Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatzapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphome Iphone");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 1", imei: "2222222222", memoria: 126);
iphone.Ligar();
iphone.InstalarAplicativo("Whatzapp");