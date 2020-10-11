using System;
using System.Numerics;

namespace ex42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = new int[51];
            int numero, impar = 3, contador = 0;
            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0 || numero >= 50)
            {
                Console.WriteLine("ERRO! Numero invalido.");
                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            for (; numero <= contador ; numero++)
            {
                sequencia[contador] = contador + impar;
                Console.Write(sequencia[contador] + ", ");
                impar = impar + 2;
            }
            Console.ReadKey();
        }
    }
}
