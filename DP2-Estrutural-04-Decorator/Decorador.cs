namespace DP2_Estrutural_04_Decorator
{
    public class Decorador : ItemBiblioteca
    {
        public Decorador(ItemBiblioteca itemBiblioteca)
        {
            this._itemBiblioteca = itemBiblioteca;
        }
        
        protected ItemBiblioteca _itemBiblioteca;
        
        public override void Exibe()
        {
            this._itemBiblioteca.Exibe();
        }
    }
}