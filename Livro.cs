using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "titulo";
            Autor = "autor";
            NumeroPaginas = 0;
        }

        public Livro(string? titulo)
        {
            Titulo = titulo;
            Autor = "autor";
            NumeroPaginas = 0;
        }

        public Livro(string? titulo, string? autor)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = 0;
        }

        public Livro(string? titulo, string? autor, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }

        public void exibirLivro()
        {
            Console.WriteLine($"{Titulo}, {Autor}, {NumeroPaginas} páginas.");
        }
    }
}