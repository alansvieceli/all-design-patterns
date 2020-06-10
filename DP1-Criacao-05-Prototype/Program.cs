using System;
using DP1_Criacao_05_Prototype.Modelo;

namespace DP1_Criacao_05_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioFixo ff = new FuncionarioFixo();
            ff.nome = "Alan";
            ff.idade = 38;

            FuncionarioFixo ffc = (FuncionarioFixo) ff.Clone();
            ffc.nome = "** Alan - Terceiro **";
            Console.WriteLine("FuncionarioFixo: Nome: {0}, Idade: {1}, Tipo: {2}", ff.nome, ff.idade, ff.tipo);
            Console.WriteLine("FuncionarioFixo - Clone: Nome: {0}, Idade: {1}, Tipo: {2}", ffc.nome, ffc.idade, ffc.tipo);
        }
    }
}