using System.Threading;

namespace DesafioPOO.Models
{
    public class Nokia :Smartphone
    {
        public Nokia(string numero,string modelo,string imei,string memoria) : base(numero,modelo,imei,memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo "+nomeApp);
            for (int i = 0; i < 10;i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine($"\nAplicativo {nomeApp} instalado com sucesso!");
        }
    }
}