using System;

namespace DP3_Comportamental_06_Memento
{
    public class Originator
    {
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
                Console.WriteLine("State: " + this._state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(this._state);
        }
        
        
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restaurando o estado");
            State = memento.State;
        }
    }
}