using DP1_Criacao_04_Builder.Abstraction;
using DP1_Criacao_04_Builder.Aparelhos;

namespace DP1_Criacao_04_Builder.Builder
{
    public class IPhoneBuilder : ICelular
    {
        public IPhoneBuilder()
        {
            this.Celular = new Celular("IPhone");
        }

        public Celular Celular { get; }

        public ICelular BuildTela()
        {
            this.Celular.Tela = "8";
            return this;
        }

        public ICelular BuildBateria()
        {
            this.Celular.Bateria = "87000";
            return this;
        }

        public ICelular BuildSistemaOperacional()
        {
            this.Celular.SO = "IOS 11";
            return this;
        }

        public ICelular BuildCamera()
        {
            this.Celular.Camera = "25 MP";
            return this;
        }
    }
}