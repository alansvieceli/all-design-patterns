namespace DP3_Comportamental_08_State
{
    public class ConcreateStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreateStateA();
        }
    }
}