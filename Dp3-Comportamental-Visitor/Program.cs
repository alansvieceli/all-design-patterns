using System;

namespace Dp3_Comportamental_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStruture o = new ObjectStruture();
            o.Anexar(new ElementoConcretoA());
            o.Anexar(new ElementoConcretoB());
            
            ConcerteVisitor01 v1 = new ConcerteVisitor01();
            ConcerteVisitor02 v2 = new ConcerteVisitor02();
            
            o.Accept(v1);
            o.Accept(v2);
        }
    }
}