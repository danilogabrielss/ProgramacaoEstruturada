using System;

namespace ex53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[11];
            int contador, maiorNumero = 0;
            for (contador = 1; contador <= 10; contador++)
            {
                Console.Write("Digite um numero: ");
                numero[contador] = Convert.ToInt32(Console.ReadLine());
                if(numero[contador] > maiorNumero)
                {
                    maiorNumero = numero[contador];
                }
            }
            Console.WriteLine("O maior numero digitado foi : " + maiorNumero);
            Console.ReadKey();
        }
    }
}
