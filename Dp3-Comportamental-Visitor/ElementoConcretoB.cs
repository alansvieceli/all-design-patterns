namespace Dp3_Comportamental_Visitor
{
    public class ElementoConcretoB : Elemento
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitarElementoConcretoB(this);
        }
        
        public void OperacaoB()
        {
            
        }
    }
}