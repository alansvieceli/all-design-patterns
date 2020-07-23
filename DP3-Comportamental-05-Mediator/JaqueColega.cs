using System;

namespace DP3_Comportamental_05_Mediator
{
    public class JaqueColega : Colega
    {
        public JaqueColega(IMediador mediador) : base(mediador)
        {
        }

        public override void Notificar(string msg)
        {
            Console.WriteLine("Mensagem JAQUE : " + msg);
        }
    }
}