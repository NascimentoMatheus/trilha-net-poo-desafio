using DesafioPOO.Models;

// Feito: Realizar os testes com as classes Nokia e Iphone
class Program
{
  static void Main()
  {
    Console.WriteLine("Smartphone Nokia:");
    Nokia nokia = new Nokia(numero: "11972918716", modelo: "Nokia 1011", imei: "1234567891011", memoria: 158);
    nokia.Ligar();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine("\n");
    Console.WriteLine("Smartphone Iphone:");
    Iphone iphone = new Iphone(numero: "11970163171", modelo: "Iphone 3G", imei: "1234567891011", memoria: 512);
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Telegram");
  }
}
