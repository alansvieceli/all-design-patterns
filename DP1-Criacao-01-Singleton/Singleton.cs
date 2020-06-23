using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instacia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (_instacia == null)
                {
                    Console.WriteLine("Criou Instancia");
                    _instacia = new Singleton();
                }
                Console.WriteLine("Pegou Instancia");
                return _instacia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
        
    }
}