using System.Collections.Generic;

namespace DP3_Comportamental_07_Observer
{
    public abstract class Assunto
    {
        private List<Observador> _observadores = new List<Observador>();

        public void Anexar(Observador observador)
        {
            this._observadores.Add(observador);
        }
        
        public void Desanexar(Observador observador)
        {
            this._observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var item in this._observadores)
            {
                item.Update();
            }
        }
        
    }
}