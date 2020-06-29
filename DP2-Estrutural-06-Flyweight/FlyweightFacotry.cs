using System.Collections.Generic;

namespace DP2_Estrutural_06_Flyweight
{
    public class FlyweightFacotry
    {
        private Dictionary<string, Tartaruga> lista = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;
            if (lista.ContainsKey(cor))
            {
                t = lista[cor];
            }
            else
            {
                switch (cor)
                {
                    case "vermelho": 
                        t = new Vermelha();
                        break;
                    case "verde": 
                        t = new Verde();
                        break;
                    case "azul": 
                        t = new Azul();
                        break;
                    case "laranja": 
                        t = new Laranja();
                        break;
                }
                lista.Add(cor, t);
            }

            return t;
        }
    }
}