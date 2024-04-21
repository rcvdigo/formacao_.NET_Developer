using DesafioSistemaAbstraindoCelular.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(
    numero: "11941982086",
    modelo: "A71",
    imei: "IMEI-NOKIA",
    memoria: 128
    );
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(
    numero: "11941982086",
    modelo: "PRO-MAX",
    imei: "IMEI-IPHONE",
    memoria: 64
    );
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "Telegram");