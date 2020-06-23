namespace DP2_Estrutural_02_Bridge
{
    public class Documentário: ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de documentários";
        }

        public string Situacao()
        {
            return "Voce está assistindo um documentário";
        }
    }
}