using System;

namespace DP3_Comportamental_05_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediador m = new Mediador();
            
            AlanColega a = new AlanColega(m);
            JaqueColega j = new JaqueColega(m);

            m.Alan = a;
            m.Jaque = j;

            a.Enviar("Como você está?");
            j.Enviar("Bem! e vc?");
            
        }
    }
}