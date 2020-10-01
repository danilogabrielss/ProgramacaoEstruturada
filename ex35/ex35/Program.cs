using System;

namespace ex35
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 1, resultado;
            do
            {
                resultado = 5 * contador;
                Console.WriteLine("5 x " + contador + " = " + resultado);
                contador = contador + 1;
            } while (contador <= 10);
        }
    }
}
