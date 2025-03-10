using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "983044330", modelo: "`G60", imei: "222222222", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "983044330", modelo: "`16 Pro MAX", imei: "111111111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");