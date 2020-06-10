using System;

namespace DP1_Criacao_04_Builder.Aparelhos
{
    public class Celular
    {
        public Celular(String nome)
        {
            this.Nome = nome;
        }

        public String Nome { get; set; }
        public String Tela { get; set; }
        public String Bateria { get; set; }
        public String SO { get; set; }
        public String Camera { get; set; }
        
        
    }
}