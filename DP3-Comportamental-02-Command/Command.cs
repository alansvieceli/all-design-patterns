namespace DP3_Comportamental_02_Command
{
    public abstract class Command
    {
        protected Receiver Receiver;

        public Command(Receiver rc)
        {
            this.Receiver = rc;
        }

        public abstract void Execute();
    }
}