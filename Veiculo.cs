using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Veiculo
    {
        public decimal Velocidade { get; set; }

        public void setVelocidade(decimal novaVelocidade)
        {
            if (novaVelocidade > 0 && novaVelocidade <= 200)
            {
                Velocidade = novaVelocidade;
                Console.WriteLine($"Velocidade: {Velocidade}km/h.");
            }
            else Console.WriteLine("Velocidade não permitida.");
        }
    }


}