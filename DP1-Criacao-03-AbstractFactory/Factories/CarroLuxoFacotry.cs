using DP1_Criacao_03_AbstractFactory.Abstraction;
using DP1_Criacao_03_AbstractFactory.Pecas;

namespace DP1_Criacao_03_AbstractFactory.Factories
{
    public class CarroLuxoFacotry :  CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
            
        }

        public override Som MontarSom()
        {
            return new SomPioner();
        }
    }
}