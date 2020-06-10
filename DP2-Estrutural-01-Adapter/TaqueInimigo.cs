using System;
using DP2_Estrutural_01_Adapter.Abstract;

namespace DP2_Estrutural_01_Adapter
{
    public class TaqueInimigo : IAtaqueInimigo
    {
        private Random gerador = new Random();
        
        public void ArmaDeFogo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Taque Inimigo Fez {0} de dano!", danoAtaque);
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine("Taque Inimigo moveu {0} espaços!", movimento);
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine("{0} está no comando do taque!", piloto);
        }
    }
}