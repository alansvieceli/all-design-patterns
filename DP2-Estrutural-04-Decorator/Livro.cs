using System;
using System.Data;

namespace DP2_Estrutural_04_Decorator
{
    public class Livro : ItemBiblioteca
    {
        public Livro(int copias, string autor, string titulo)
        {
            this.NumeroCopias = copias;
            this.Autor = autor;
            this.Titulo = titulo;
        }


        public  string Autor { get; set; }
        public string Titulo { get; set; }
        
        public override void Exibe()
        {
            Console.WriteLine("\nLivro ----");
            Console.WriteLine(" Autor: " + this.Autor);
            Console.WriteLine(" Titulo: " + this.Titulo);
            Console.WriteLine(" NumeroCopias: " + this.NumeroCopias);
        }
    }
}