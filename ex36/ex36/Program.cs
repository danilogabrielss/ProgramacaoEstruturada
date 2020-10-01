using System;

namespace ex36
{
    class Program
    {
        static void Main(string[] args)
        {
            double tabuada ,contador = 1, resultado;
            Console.Write("Digite um numero: ");
            tabuada = double.Parse(Console.ReadLine());
            while (tabuada < 0)
            {
                Console.WriteLine("Numero invalido!");
                Console.Write("Digite outro número: ");
                tabuada = double.Parse(Console.ReadLine());
            } 
            do
            {
                resultado = tabuada * contador ;
                Console.WriteLine(tabuada + "x " + contador + " = " + resultado);
                contador = contador + 1;
            } while (contador <= 10);
        }
    }
}
