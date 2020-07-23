using System;
using System.Net;

namespace DP3_Comportamental_06_Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            
            Carataker c = new Carataker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            
            o.SetMemento(c.Memento);
        }
    }
}