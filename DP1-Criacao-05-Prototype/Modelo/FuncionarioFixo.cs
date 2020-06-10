using System;
using DP1_Criacao_05_Prototype.Abstract;

namespace DP1_Criacao_05_Prototype.Modelo
{
    public class FuncionarioFixo : IFuncionario
    {
        
        public FuncionarioFixo()
        {
            this.tipo = "FIXO";
        }
        
        public String nome { get; set; }
        public String tipo { get; }
        public int idade { get; set; }
        
        public IFuncionario Clone()
        {
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}