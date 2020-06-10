using DP1_Criacao_04_Builder.Aparelhos;

namespace DP1_Criacao_04_Builder.Abstraction
{
    public interface ICelular
    {
        ICelular BuildTela();
        ICelular BuildBateria();
        ICelular BuildSistemaOperacional();
        ICelular BuildCamera();
        
        Celular Celular { get; }
    }
}