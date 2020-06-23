using System;

namespace DP2_Estrutural_04_Decorator
{
    public class Video : ItemBiblioteca
    {
        public Video(int copias, string diretor, int tempo, string titulo)
        {
            this.NumeroCopias = copias;
            this.Diretor = diretor;
            this.Titulo = titulo;
            this.Tempo = tempo;
        }


        public  string Diretor { get; set; }
        public string Titulo { get; set; }
        
        public int Tempo { get; set; }
        
        public override void Exibe()
        {
            Console.WriteLine("\nFilme ----");
            Console.WriteLine(" Diretor: " + this.Diretor);
            Console.WriteLine(" Titulo: " + this.Titulo);
            Console.WriteLine(" Tempo: " + this.Tempo);
            Console.WriteLine(" NumeroCopias: " + this.NumeroCopias);
        }
    }
}