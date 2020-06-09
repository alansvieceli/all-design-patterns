using System;
using FactoryMethod.Abstraction;

namespace FactoryMethod.Personagens
{
    public class LiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Liu Kang");
        }
    }
}