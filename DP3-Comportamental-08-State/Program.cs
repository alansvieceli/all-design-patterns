using System;

namespace DP3_Comportamental_08_State
{
    class Program
    {
        static void Main(string[] args)
        {
           Context c = new Context(new ConcreateStateA());
           
           c.Request();
           c.Request();
           c.Request();
           c.Request();
        }
    }
}