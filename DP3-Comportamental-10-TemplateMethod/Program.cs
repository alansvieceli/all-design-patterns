using System;

namespace DP3_Comportamental_10_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a = new ConreteCalssA();
            a.TemplateMethod();
            
            AbstractClass b = new ConreteCalssB();
            b.TemplateMethod();
        }
    }
}