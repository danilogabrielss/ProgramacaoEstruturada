using System;

namespace ex39
{
    class Program
    {
        static void Main(string[] args)
        {
            double contador = 1, contador1 = 1 , resultado;
            do
            {
                resultado = contador + contador1;
                Console.WriteLine(contador1 + " + " + contador + " = " + resultado);
                contador1 = contador;
                contador = contador + 1;
            } while (resultado <= 100);
        }
    }
}
