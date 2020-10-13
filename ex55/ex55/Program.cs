using System;

namespace ex55
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];
            int[] multp = new int[20];
            int contador, multiplicador;
            string continuar = "S";
            do
            {     
                for (contador = 0; contador < 20; contador++)
                {
                    Console.Write("Digite um numero: ");
                    numero[contador] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Digite o multiplicador: ");
                multiplicador = Convert.ToInt32(Console.ReadLine());
                for (contador = 0; contador < 20; contador++)
                {
                    multp[contador] = multiplicador * numero[contador];
                    Console.WriteLine("O numero  " + numero[contador] + " x " + multiplicador + " é igual a " + multp[contador]);
                }
                    Console.Write("Deseja continuar (S//N): ");
                continuar = Console.ReadLine();
            } while (continuar == "S");
        }
    }
}
