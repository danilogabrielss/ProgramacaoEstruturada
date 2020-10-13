using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ex56
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];
            int contador, digitar, procurar, procurarContador = 0;
            string continuar = "S";
            do
            {
                Console.Write("Digite a quantidade de numeros a ser digitadas: ");
                digitar = Convert.ToInt32(Console.ReadLine());
                while (digitar > 20 || digitar < 0)
                {
                    Console.Write("Numero Invalido!");
                    Console.WriteLine("Digite a quantidade de numeros a ser digitadas: ");
                    digitar = Convert.ToInt32(Console.ReadLine());
                }
                for (contador = 0; contador < digitar; contador++)
                {
                    Console.Write("Digite um numero: ");
                    numero[contador] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Digite o numero a ser procurado: ");
                procurar = Convert.ToInt32(Console.ReadLine());

                for (contador = 0; contador < digitar; contador++)
                {
                    if (procurar == numero[contador])
                    {
                        procurar = numero[contador];
                        procurarContador = contador;
                    }
                }
                if (procurar != 0)
                {
                    Console.WriteLine("O numero " + procurar + " esta no vetor " + procurarContador);
                }
                else
                {
                    Console.WriteLine("O numero " + procurar + " não foi encontrado");
                }
                Console.Write("Deseja continuar (S//N)");
                continuar = Console.ReadLine();
            } while (continuar == "S");
        }
    }
}
