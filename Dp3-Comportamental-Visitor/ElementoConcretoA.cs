namespace Dp3_Comportamental_Visitor
{
    public class ElementoConcretoA : Elemento
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitarElementoConcretoA(this);
        }

        public void OperacaoA()
        {
            
        }
    }
}