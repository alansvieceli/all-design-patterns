using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace DP2_Estrutural_03_Adapter
{
    public class Composite : Componente
    {

        private List<Componente> _componentes = new List<Componente>();
        
        public Composite(string nome) : base(nome)
        {
            
        }

        public override void Add(Componente c)
        {
            this._componentes.Add(c);
        }

        public override void Remover(Componente c)
        {
            this._componentes.Remove(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + base.Nome);
            foreach (var componente in this._componentes)
            {
                componente.Mostrar(profundidade + 2);
            }
        }
    }
}