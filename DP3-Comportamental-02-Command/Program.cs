using System;

namespace DP3_Comportamental_02_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver rc = new Receiver();
            Command cmd = new TrueCommand(rc);
            Invocar inv = new Invocar();
            
            inv.SetCommand(cmd);
            inv.ExecuteCommand();
        }
    }
}