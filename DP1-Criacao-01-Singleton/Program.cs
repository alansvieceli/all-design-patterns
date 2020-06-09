using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.GetInstancia.Mensagem("Teste 1");
            Singleton.GetInstancia.Mensagem("Teste 2");
        }
    }
}