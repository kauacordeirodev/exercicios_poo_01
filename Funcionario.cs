using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; private set; }

        public Funcionario()
        {
            Nome = "Indefinido";
            Cargo = "Indefinido";
            Salario = 0;
        }

        public void AlterarSalario(decimal novoSalario)
        {
            Salario = novoSalario;
        }

        public void AumentarSalario(decimal percentual)
        {
            Salario = Salario + (Salario * percentual / 100);
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário atual: {Salario:C}");
        }

        public void ConsultarFuncionario()
        {
            Console.WriteLine($"{Nome}, {Cargo}, {Salario:C}");
        }
    }

}