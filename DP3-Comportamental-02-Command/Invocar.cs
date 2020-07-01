namespace DP3_Comportamental_02_Command
{
    public class Invocar
    {
        private Command _command;

        public void SetCommand(Command c)
        {
            this._command = c;
        }

        public void ExecuteCommand()
        {
            this._command.Execute();
        }
    }
}