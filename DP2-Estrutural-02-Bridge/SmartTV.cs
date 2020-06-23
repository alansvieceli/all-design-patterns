using System;

namespace DP2_Estrutural_02_Bridge
{
    public class SmartTv // < essa é a bridge
    {
        public ICanal CanalAtual { get; set; }

        public void ExibeSituacao()
        {
            if ( CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Canal());
            }
            else
            {
                Console.WriteLine("Nenhum canal sintonizado");
            }
        }

        public void PlayTv()
        {
            if ( CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Situacao());
            }
            else
            {
                Console.WriteLine("Nenhum canal sintonizado");
            }
        }
    }
}