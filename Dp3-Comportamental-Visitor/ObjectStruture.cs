using System.Collections.Generic;

namespace Dp3_Comportamental_Visitor
{
    public class ObjectStruture
    {
        private List<Elemento> _elementos = new List<Elemento>();

        public void Anexar(Elemento elemento)
        {
            this._elementos.Add(elemento);
        }
        
        public void Desanexar(Elemento elemento)
        {
            this._elementos.Remove(elemento);
        }
        
        public void Accept(Visitor visitor)
        {
            foreach (var elemento in this._elementos)
            {
                elemento.Accept(visitor);
            }
        }
    }
}