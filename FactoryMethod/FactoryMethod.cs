using FactoryMethod.Abstraction;
using FactoryMethod.Personagens;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "LIU KANG" : return new LiuKang();
                case "RAIDEN" : return new Raiden();
                case "SCORPION" : return new Scorpion();
                case "KABAL" : return new Kabal();
                default: return null;
            }
        }
    }
}