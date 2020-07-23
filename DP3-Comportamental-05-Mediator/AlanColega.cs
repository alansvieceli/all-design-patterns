using System;

namespace DP3_Comportamental_05_Mediator
{
    public class AlanColega : Colega
    {
        public AlanColega(IMediador mediador) : base(mediador)
        {
            
        }

        public override void Notificar(string msg)
        {
            Console.WriteLine("Mensagem ALAN : " + msg);
        }
    }
}