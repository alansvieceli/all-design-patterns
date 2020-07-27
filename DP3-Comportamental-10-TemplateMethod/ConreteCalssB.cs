using System;

namespace DP3_Comportamental_10_TemplateMethod
{
    public class ConreteCalssB : AbstractClass
    {
        public override void PrimitiveOperation01()
        {
            Console.WriteLine("ConreteCalssB.PrimitiveOperation02");
        }

        public override void PrimitiveOperation02()
        {
            Console.WriteLine("ConreteCalssB.PrimitiveOperation02");
        }
    }
}