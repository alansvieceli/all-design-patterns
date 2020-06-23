namespace DP2_Estrutural_02_Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de culinária";
        }

        public string Situacao()
        {
            return "Voce está assistindo uma receita";
        }
    }
}