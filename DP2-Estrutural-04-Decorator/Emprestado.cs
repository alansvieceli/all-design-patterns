using System;
using System.Collections.Generic;

namespace DP2_Estrutural_04_Decorator
{
    public class Emprestado : Decorador
    {
        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
            
        }
        
        protected List<string> emprestados = new List<string>();

        public void EmprestarItem(string nome)
        {
            this.emprestados.Add(nome);
            this._itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(string nome)
        {
            this.emprestados.Remove(nome);
            this._itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach (var item in emprestados)
            {
                Console.WriteLine("Emprestado: "+ item);
            }
        }
    }
}