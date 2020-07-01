using System;

namespace DP3_Comportamental_01_ChainOfResponsibility
{
    public class ConcreteHandler03 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
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