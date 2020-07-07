namespace DP3_Comportamental_03_Interpreter
{
    public class TenExpression : Expression
    {
        public override string One()
        {
            return "X";
        }

        public override string Four()
        {
            return "XL";
        }

        public override string Five()
        {
            return "L";
        }

        public override string Nine()
        {
            return "XC";
        }

        public override int Multiply()
        {
            return 10;
        }
    }
}