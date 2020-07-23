using System;

namespace DP3_Comportamental_06_Memento
{
    public class Memento
    {
        public Memento(string state)
        {
            this._state = state;
        }
        
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
        }

    }
}