using System;

namespace ex52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[11];
            int contador;
            for (contador = 1; contador <= 10; contador++)
            {
                Console.Write("Digite um numero: ");
                numero[contador] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (contador = 10; contador >= 1; contador--)
            {
                Console.WriteLine(numero[contador]);
            }
            Console.ReadKey();
        }
    }
}
