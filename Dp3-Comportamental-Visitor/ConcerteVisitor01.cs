using System;

namespace Dp3_Comportamental_Visitor
{
    public class ConcerteVisitor01 : Visitor
    {
        public override void VisitarElementoConcretoA(ElementoConcretoA elementoConcretoA)
        {
            
            Console.WriteLine("{0} visitado por {1}", elementoConcretoA.GetType().Name, this.GetType().Name);
        }

        public override void VisitarElementoConcretoB(ElementoConcretoB elementoConcretoB)
        {
            Console.WriteLine("{0} visitado por {1}", elementoConcretoB.GetType().Name, this.GetType().Name);
        }
    }
}