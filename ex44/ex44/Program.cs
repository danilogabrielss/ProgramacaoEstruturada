using System;

namespace ex44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequencia = new int[51];
            int numero, impar = 3, potencia = 1, potenciaBase;
            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0 || numero >= 50)
            {
                Console.WriteLine("ERRO! Numero invalido.");
                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            for (; numero <= 20; numero++, potencia++)
            {
                sequencia[numero] = numero + impar;
                potenciaBase = potencia * (potencia * potencia);
                Console.WriteLine(sequencia[numero] + "\n______\n " + potenciaBase + "\n");
                impar = impar + 2;
            }
            Console.ReadKey();
        }
    }
}
