using System;
using System.ComponentModel;
using DP1_Criacao_03_AbstractFactory.Veiculos;

namespace DP1_Criacao_03_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutaAbstractFactory.MontarCarro("LUXO");
            Console.WriteLine("*** Carro de Luxo Criado ***");
            ExecutaAbstractFactory.MontarCarro("POPULAR");
            Console.WriteLine("*** Carro de Popular Criado ***");
        }
    }
}