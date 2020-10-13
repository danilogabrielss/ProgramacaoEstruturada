using System;

namespace ex48
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitar, contador, resultado;
            string continuar = "S";
            do
            {
                Console.Write("Digite um numero: ");
                digitar = Convert.ToInt32(Console.ReadLine());
                while (digitar < 0)
                {
                    Console.WriteLine("Numero Invalido!");
                    Console.Write("Digite um numero: ");
                    digitar = Convert.ToInt32(Console.ReadLine());
                }
                resultado = 1;
                for (contador = 1; contador <= digitar ;contador++ )  
                {                   
                    resultado = contador * resultado;
                    ;
                }
                Console.WriteLine("O fatorial de " + digitar + " é igual a " + resultado);
                Console.Write("Deseja continuar? (S//N): ");
                continuar = Console.ReadLine();
            } while (continuar == "S");
        }
    }
}
