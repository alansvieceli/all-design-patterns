using System;
using FactoryMethod.Abstraction;

namespace FactoryMethod.Personagens
{
    public class Kabal : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Kabal");
        }
    }
}