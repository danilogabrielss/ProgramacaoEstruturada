using System;

namespace ex37
{
    class Program
    {
        static void Main(string[] args)
        {
            double tabuada, contador, resultado;
            Console.Write("Digite um numero: ");
            tabuada = double.Parse(Console.ReadLine());
            while (tabuada < 0)
            {
                Console.WriteLine("Numero invalido!");
                Console.Write("Digite outro número: ");
                tabuada = double.Parse(Console.ReadLine());
            }
            Console.Write("Digite um numero: ");
            contador = double.Parse(Console.ReadLine());
            while (contador < tabuada)
            {
                Console.WriteLine("Numero invalido!");
                Console.Write("Digite outro número: ");
                contador = double.Parse(Console.ReadLine());
            }
            do
            {
                resultado = tabuada * contador;
                Console.WriteLine(tabuada + " x " + contador + " = " + resultado);
                contador = contador - 1;
            } while (contador >= 1);
        }
    }
}
