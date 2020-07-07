namespace DP3_Comportamental_03_Interpreter
{
    public class UnityExpression : Expression
    {
        public override string One()
        {
            return "I";
        }

        public override string Four()
        {
            return "IV";
        }

        public override string Five()
        {
            return "V";
        }

        public override string Nine()
        {
            return "IX";
        }

        public override int Multiply()
        {
            return 1;
        }
    }
}