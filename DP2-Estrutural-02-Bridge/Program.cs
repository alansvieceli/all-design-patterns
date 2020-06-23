using System;

namespace DP2_Estrutural_02_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new SmartTv();
            Console.WriteLine("Selecione um canal");
            Console.WriteLine("1 - FILMES");
            Console.WriteLine("2 - DOCUMENTÁRIO");
            Console.WriteLine("3 - CULINÁRIA");
            
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    tv.CanalAtual = new Filme();
                    break;
                case '2':
                    tv.CanalAtual = new Documentário();
                    break;
                case '3':
                    tv.CanalAtual = new Culinaria();
                    break;
            }
            
            Console.WriteLine();
            
            tv.ExibeSituacao();
            tv.PlayTv();
            
            
        }
    }
}