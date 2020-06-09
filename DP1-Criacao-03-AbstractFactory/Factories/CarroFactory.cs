using DP1_Criacao_03_AbstractFactory.Abstraction;

namespace DP1_Criacao_03_AbstractFactory.Factories
{
    public abstract class CarroFactory
    {
        public abstract Roda MontarRoda();
        public abstract Som MontarSom();
    }
}