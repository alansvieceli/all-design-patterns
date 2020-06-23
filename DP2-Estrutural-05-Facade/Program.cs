using System;

namespace DP2_Estrutural_05_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Facade();
            
            f.MetodoA();
            f.MetodoB();
            f.MetodoC();
        }
    }
}