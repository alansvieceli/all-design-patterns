using System;

namespace DP3_Comportamental_08_State
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            this.State = state;
        }
        
        public State State
        {
            get => this._state;
            set
            {
                this._state = value;
                Console.WriteLine("Estado: {0}", this._state.GetType().Name);
            }
        }

        public void Request()
        {
            this._state.Handle(this);
        }
    }
}