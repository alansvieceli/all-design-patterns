using System;
using DP1_Criacao_03_AbstractFactory.Abstraction;

namespace DP1_Criacao_03_AbstractFactory.Pecas
{
    public class SomPioner : Som
    {
        public SomPioner()
        {
            Console.WriteLine("Criou Som PIONER");
        }
    }
}