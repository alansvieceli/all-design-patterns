namespace DP2_Estrutural_05_Facade
{
    public class Facade
    {
        public Facade()
        { 
            um = new SubSistemaUm();
            dois = new SubSistemaDois();
            tres  = new SubSistemaTres();
        }
    
        private SubSistemaUm um;
        private SubSistemaDois dois;
        private SubSistemaTres tres;

        public void MetodoA()
        {
            um.MetodoUm();
        }
        
        public void MetodoB()
        {
            dois.MetodoDois();
        }
        
        public void MetodoC()
        {
            tres.MetodoTres();
        }
            
            


    }
}