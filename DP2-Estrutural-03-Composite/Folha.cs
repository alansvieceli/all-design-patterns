using System;

namespace DP2_Estrutural_03_Adapter
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
        }

        public override void Add(Componente c)
        {
            Console.WriteLine("Não é possível adiconar folha");
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Não é possível remover folha");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + base.Nome);
        }
    }
}