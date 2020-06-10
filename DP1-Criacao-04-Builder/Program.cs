using System;
using DP1_Criacao_04_Builder.Abstraction;
using DP1_Criacao_04_Builder.Builder;

namespace DP1_Criacao_04_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fab = new Fabricante();
            ICelular celularBuild = new AndroidBuilder();
            fab.Construtor(celularBuild);
            Console.WriteLine(celularBuild.Celular.Nome.ToUpper());
            
            
            ICelular celularBuild2 = new IPhoneBuilder();
            fab.Construtor(celularBuild2);
            Console.WriteLine(celularBuild2.Celular.Nome.ToUpper());
        }
    }
}