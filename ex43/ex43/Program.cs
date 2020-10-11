using System;

namespace ex43
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = new int[51];
            int denominador= 1, numero;
            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0 || numero >= 50)
            {
                Console.WriteLine("ERRO! Numero invalido.");
                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            for (; numero <= 50; numero++)
            {
                denominador = numero + 1;
                sequencia[numero] = numero;
                Console.WriteLine(sequencia[numero] + "\n _ \n" + denominador + " , ");
            }
            Console.ReadKey();
        }
    }
}
