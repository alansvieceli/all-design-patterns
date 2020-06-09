using System;
using DP1_Criacao_03_AbstractFactory.Abstraction;

namespace DP1_Criacao_03_AbstractFactory.Pecas
{
    public class RodaSimples : Roda
    {
        public RodaSimples()
        {
            Console.WriteLine("Criou Roda SIMPLES");
        }
    }
}