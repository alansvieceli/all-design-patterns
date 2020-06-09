using System;
using FactoryMethod.Abstraction;

namespace FactoryMethod.Personagens
{
    public class Raiden : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Raiden");
        }
    }
}