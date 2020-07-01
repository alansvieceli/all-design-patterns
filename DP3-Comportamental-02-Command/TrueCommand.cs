namespace DP3_Comportamental_02_Command
{
    public class TrueCommand : Command
    {
        public TrueCommand(Receiver rc) : base(rc)
        {
            
        }

        public override void Execute()
        {
            Receiver.Action();
        }
    }
}