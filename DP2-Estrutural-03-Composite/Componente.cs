namespace DP2_Estrutural_03_Adapter
{
    public abstract class Componente
    {
        public Componente(string nome)
        {
            this.Nome = nome;
        }
        
        protected string Nome;

        public abstract void Add(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidade);
    }
}