using System;

namespace DP3_Comportamental_10_TemplateMethod
{
    public class ConreteCalssA : AbstractClass
    {
        public override void PrimitiveOperation01()
        {
            Console.WriteLine("ConreteCalssA.PrimitiveOperation01");

        }

        public override void PrimitiveOperation02()
        {
            Console.WriteLine("ConreteCalssA.PrimitiveOperation02");
        }
    }
}