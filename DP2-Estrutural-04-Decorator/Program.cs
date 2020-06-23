using System;

namespace DP2_Estrutural_04_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro(5,"Autor01", "Livro01");
            livro.Exibe();
            
            Video video = new Video(7,"Diretor01", 90,"Filme01");
            video.Exibe();
            
            Console.WriteLine("Emprestando...");
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Alan");
            emprestado.EmprestarItem("Jaque");
            emprestado.EmprestarItem("Rosa");
            emprestado.Exibe();
            emprestado.DevolverItem("Jaque");
            emprestado.Exibe();
        }
    }
}