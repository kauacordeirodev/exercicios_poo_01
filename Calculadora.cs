namespace ExerciciosPOO
{
    public class Calculadora
    {
        public decimal a { get; set; }
        public decimal b { get; set; }
        
        public void Somar()
        {
            Console.WriteLine(a + b);
        }

        public void Subtrair()
        {
            
            Console.WriteLine(a - b);
        }

        public void Multiplicar()
        {
            
            Console.WriteLine(a * b);
        }
        public static void Dividir(decimal x, decimal y)
        {
            if(y != 0) Console.WriteLine(x / y);
            else Console.WriteLine("Não é permitido dividir por 0.");
        }
    }
}