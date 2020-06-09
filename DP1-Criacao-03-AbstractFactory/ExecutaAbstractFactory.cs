using DP1_Criacao_03_AbstractFactory.Factories;
using DP1_Criacao_03_AbstractFactory.Veiculos;

namespace DP1_Criacao_03_AbstractFactory
{
    public class ExecutaAbstractFactory
    {
        public static Carro MontarCarro(string tipo)
        {
            CarroFactory factory = null;
            switch (tipo)
            {
                case "LUXO":  
                    factory = new CarroLuxoFacotry();
                    break;
                case "POPULAR":  
                    factory = new CarroPopularFactory();
                    break;
            }
            
            Carro carro = new Carro();
            carro.roda = factory?.MontarRoda();
            carro.som = factory?.MontarSom();

            return carro;
        }
    }
}