using DP1_Criacao_04_Builder.Abstraction;
using DP1_Criacao_04_Builder.Aparelhos;

namespace DP1_Criacao_04_Builder.Builder
{
    public class AndroidBuilder : ICelular
    {
        public AndroidBuilder()
        {
            this.Celular = new Celular("Android");
        }
        
        public Celular Celular { get; }
        
        public ICelular BuildTela()
        {
            this.Celular.Tela = "7";
            return this;
        }

        public ICelular BuildBateria()
        {
            this.Celular.Bateria = "5000";
            return this;
        }

        public ICelular BuildSistemaOperacional()
        {
            this.Celular.SO = "Android 4.2";
            return this;
        }

        public ICelular BuildCamera()
        {
            this.Celular.Camera = "15 MP";
            return this;
        }
    }
}