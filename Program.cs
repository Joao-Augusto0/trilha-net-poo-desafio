using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "111111111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("-------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Modelo 23", imei: "2222222222", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");