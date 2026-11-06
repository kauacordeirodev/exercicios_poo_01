using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cidade { get; set; }

        public Pessoa()
        {
            Nome = "Indefinido";
            Idade = 0;
            Cidade = "Indefinida";
        }

        public void Apresentar()
        {
            Console.WriteLine($"{Nome}, {Idade} anos, de {Cidade}");
        }
    }
}