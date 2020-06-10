using DP2_Estrutural_01_Adapter.Abstract;

namespace DP2_Estrutural_01_Adapter
{
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        public RoboInimigoAdapter(RoboInimigo robo)
        {
            this._robo = robo;
        }

        private RoboInimigo _robo;
        
        public void ArmaDeFogo()
        {
            this._robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this._robo.AndarParaFrente();
        }

        public void Pilotar(string piloto)
        {
            this._robo.ReagirContraHumano(piloto);
        }
    }
}