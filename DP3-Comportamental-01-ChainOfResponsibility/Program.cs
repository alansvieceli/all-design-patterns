using System;

namespace DP3_Comportamental_01_ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler01();
            Handler h2 = new ConcreteHandler02();
            Handler h3 = new ConcreteHandler03();
            
            h1.SetSucessor(h2);
            h2.SetSucessor(h3);

            int[] requests = {2, 5, 13, 33, 24, 12, 33, 26};

            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }
        }
    }
}