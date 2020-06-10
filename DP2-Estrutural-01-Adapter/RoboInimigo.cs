using System;

namespace DP2_Estrutural_01_Adapter
{
    //Será adaptado
    public class RoboInimigo
    {
        private Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Robô Inimigo Fez {0} de dano (Com as mãos)!", danoAtaque);
        }
        
        public void AndarParaFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("Robô Inimigo moveu {0} paços para frente!", movimento);
        }

        public void ReagirContraHumano(String piloto)
        {
            Console.WriteLine("O Robô vai contra o {0}", piloto);
        }
    }
}