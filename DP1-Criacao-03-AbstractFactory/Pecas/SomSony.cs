using System;
using DP1_Criacao_03_AbstractFactory.Abstraction;

namespace DP1_Criacao_03_AbstractFactory.Pecas
{
    public class SomSony: Som
    {
        public SomSony()
        {
            Console.WriteLine("Criou Som SONY");
        }
    }
}