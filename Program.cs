using DesafioPOO.Models;

Iphone celIpho1 = new Iphone(numero: "14996153412", modelo: "13 pro max", imei: "654523442341", memoria: "256gb");
celIpho1.Ligar();
celIpho1.ReceberLigacao();
celIpho1.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------------");

Nokia celNokia1 = new Nokia(numero: "14996296042", modelo: "c20", imei: "21312312321", memoria: "64gb");
celNokia1.Ligar();
celNokia1.ReceberLigacao();
celNokia1.InstalarAplicativo("Facebook");
