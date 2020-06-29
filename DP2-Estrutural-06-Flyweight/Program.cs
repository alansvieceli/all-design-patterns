using System;

namespace DP2_Estrutural_06_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFacotry fabrica = new FlyweightFacotry();

            string cor = string.Empty;
            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar para tela: ");
                cor = Console.ReadLine();
                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);
                Console.WriteLine();
                Console.WriteLine("--------------------------------");
            }
        }
    }
}