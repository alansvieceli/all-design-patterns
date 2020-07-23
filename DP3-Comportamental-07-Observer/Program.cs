using System;

namespace DP3_Comportamental_07_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar( new ObservadorConcreto(s, "X"));
            s.Anexar( new ObservadorConcreto(s, "Y"));
            s.Anexar( new ObservadorConcreto(s, "Z"));

            s.EstadoAssunto = "ABC";
            s.Notificar();
            
        }
    }
}