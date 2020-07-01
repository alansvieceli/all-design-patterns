using System;

namespace DP3_Comportamental_01_ChainOfResponsibility
{
    public class ConcreteHandler02 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} Handled request {1}", this.GetType().Name, request);
            } 
            else if (sucessor != null)
            {
                sucessor.HandleRequest(request);
            }
        }
    }
}