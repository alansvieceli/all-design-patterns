namespace Dp3_Comportamental_Visitor
{
    public abstract class Elemento
    {
        public abstract void Accept(Visitor visitor);
    }
}