using DP1_Criacao_04_Builder.Abstraction;

namespace DP1_Criacao_04_Builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder
                .BuildBateria()
                .BuildSistemaOperacional()
                .BuildTela()
                .BuildCamera();
        }
    }
}