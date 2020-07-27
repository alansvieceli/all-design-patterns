using System;

namespace DP3_Comportamental_10_TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation01();
        
        public abstract void PrimitiveOperation02();

        public void TemplateMethod()
        {
            PrimitiveOperation01();
            PrimitiveOperation02();
            
            Console.WriteLine();
        }
    }
}