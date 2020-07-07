namespace DP3_Comportamental_03_Interpreter
{
    public class ThousandExpression : Expression
    {
        public override string One()
        {
            return "M";
        }

        public override string Four()
        {
            return " ";
        }

        public override string Five()
        {
            return " ";
        }

        public override string Nine()
        {
            return " ";
        }

        public override int Multiply()
        {
            return 1000;
        }
    }
}