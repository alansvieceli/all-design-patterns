using DP1_Criacao_03_AbstractFactory.Abstraction;
using DP1_Criacao_03_AbstractFactory.Pecas;

namespace DP1_Criacao_03_AbstractFactory.Factories
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new SomSony();
        }
    }
}