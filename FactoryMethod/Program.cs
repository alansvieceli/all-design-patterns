using System;
using FactoryMethod.Abstraction;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FactoryMethod();
            
            Console.WriteLine("Kabal | Raiden | Liu Kang | Scorpion");
            Console.WriteLine("");
            Console.WriteLine("Escolha seu personagem");
            var escolha = Console.ReadLine();

            if (escolha != null)
            {
                IPersonagem personagem = factory.EscolherPersonagem(escolha.ToUpper());
                Console.WriteLine("");
                Console.Write("Você escolheu: ");
                personagem.Escolhido();
            }
            else
            {
                Console.WriteLine("Nenhum Personagem Escolhido");
            }

            Console.ReadKey();

        }
    }
}