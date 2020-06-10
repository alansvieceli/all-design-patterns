using System;
using DP1_Criacao_05_Prototype.Abstract;

namespace DP1_Criacao_05_Prototype.Modelo
{
    public class FuncionarioTerceirizado : IFuncionario
    {
        public FuncionarioTerceirizado()
        {
            tipo = "TERCEIRIZADO";
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