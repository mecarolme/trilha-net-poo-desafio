using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO.Models
{
    class Program
    {
        static void Main()
        {
            Nokia nokia = new Nokia("(81)91234-5678", "Nokia 5.4", "IMEI123", 128);
            Iphone iphone = new Iphone("(81)99876-5432", "Iphone 13", "IMEI456", 256);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
