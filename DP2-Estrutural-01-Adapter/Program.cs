using System;
using DP2_Estrutural_01_Adapter.Abstract;

namespace DP2_Estrutural_01_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TaqueInimigo taque = new TaqueInimigo();
            taque.ArmaDeFogo();
            taque.Movimenta();
            taque.Pilotar("Alan");
            Console.WriteLine("------------------------------------------");
            RoboInimigo robo = new RoboInimigo();
            robo.EsmagarComMaos();
            robo.AndarParaFrente();
            robo.ReagirContraHumano("Jaque");
            Console.WriteLine("------------------------------------------");
            IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(robo);
            robo_adapter.ArmaDeFogo();
            robo_adapter.Movimenta();
            robo_adapter.Pilotar("Alan");
            
        }
    }
}