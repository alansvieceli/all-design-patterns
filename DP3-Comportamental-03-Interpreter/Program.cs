using System;
using System.Collections.Generic;

namespace DP3_Comportamental_03_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroRomano = "MCMXXVIII";
            Context contexto = new Context(numeroRomano);
            
            List<Expression> lista = new List<Expression>();
            
            lista.Add(new ThousandExpression());
            lista.Add(new HundredExpression());
            lista.Add(new TenExpression());
            lista.Add(new UnityExpression());

            foreach (Expression item in lista)
            {
                item.Interpreter(contexto);
            }
            
            Console.WriteLine("{0} = {1}", numeroRomano, contexto.Output);
        }
    }
}