using System;

namespace DP2_Estrutural_03_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("ROOT");
            root.Add(new Folha("Folha A"));
            root.Add(new Folha("Folha B"));
            root.Add(new Folha("Folha C"));
            
            
            Composite comp = new Composite("COMP");
            comp.Add(new Folha("Folha AA"));
            comp.Add(new Folha("Folha AB"));
            comp.Add(new Folha("Folha AC"));

            root.Add(comp);
            
            root.Add(new Folha("FOLHA"));
            
            Folha folha = new Folha("FOLHA D");
            root.Add(folha);
            root.Remover(folha);
            
            root.Mostrar(1);
        }
    }
}