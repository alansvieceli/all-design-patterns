using System;

namespace DP2_Estrutural_07_Proxy
{
    public class RealSubject : Subject
    {
        public override void Requisicao()
        {
            Console.WriteLine("Chamando RealSubject");
        }
    }
}