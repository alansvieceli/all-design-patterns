namespace Dp3_Comportamental_Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitarElementoConcretoA(ElementoConcretoA ce);
        
        public abstract void VisitarElementoConcretoB(ElementoConcretoB ce);
    }
}