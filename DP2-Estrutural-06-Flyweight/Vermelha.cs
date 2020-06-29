using System;

namespace DP2_Estrutural_06_Flyweight
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
        {
            this.condicao = "Dentro do casco, ";
            this.acao = "Rodando no chão - ";
            
        }
        public override void Mostra(string c)
        {
            this.cor = c;
            Console.WriteLine( this.condicao + this.acao + this.cor.ToUpper());
        }
    }
}