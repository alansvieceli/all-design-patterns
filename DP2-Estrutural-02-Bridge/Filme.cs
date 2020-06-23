using System;

namespace DP2_Estrutural_02_Bridge
{
    public class Filme : ICanal
    {
         public string Canal()
         {
             return "Sintonizado no canal de filmes";
         }

        public string Situacao()
        {
            return "Voce está assistindo um filme";
        }
    }
}