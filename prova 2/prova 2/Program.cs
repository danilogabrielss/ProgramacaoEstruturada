using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace prova_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[50];
            int[] peso = new int[50];
            int[] altura = new int[50];
            string[] nome = new string[50];
            string[] sexo = new string[50];
            int contador = 0, maiorAltura = 0, maiorPeso = 0, somaIdade = 0, mediaIdade = 0, x = 0;
            string nomeMaiorAltura = "a", nomeMaiorPeso = "a";
            for (contador = 1; x == 0; contador++)
            {
                Console.Write("Digite seu nome: ");
                nome[contador] = Console.ReadLine();
                if (nome[contador] == "finalizar")
                {
                    x = 1;
                }
                else
                {
                    Console.Write("Digite seu sexo: (F//M) ");
                    sexo[contador] = Console.ReadLine();
                    while (sexo[contador] != "M" && sexo[contador] != "F")
                    {
                        Console.WriteLine("Sexo Invalido!");
                        Console.Write("Digite seu sexo: ");
                        sexo[contador] = Console.ReadLine();
                    }
                    Console.Write("Digite seu idade: ");
                    idade[contador] = Convert.ToInt32(Console.ReadLine());
                    while (idade[contador] <= 0 || idade[contador] >= 140)
                    {
                        Console.WriteLine("Idade Invalida!");
                        Console.Write("Digite sua idade: ");
                        idade[contador] = Convert.ToInt32(Console.ReadLine());
                    }
                    somaIdade = somaIdade + idade[contador];
                    Console.Write("Digite seu peso em kg: ");
                    peso[contador] = Convert.ToInt32(Console.ReadLine());
                    while (peso[contador] <= 0 || peso[contador] >= 600)
                    {
                        Console.WriteLine("Numero Invalido!");
                        Console.Write("Digite seu peso em kg: ");
                        peso[contador] = Convert.ToInt32(Console.ReadLine());
                    }
                    if (maiorPeso >= peso[contador] || sexo[contador] == "F")
                    {
                        maiorPeso = peso[contador];
                        nomeMaiorPeso = nome[contador];
                    }
                    Console.Write("Digite sua altura em cm: ");
                    altura[contador] = Convert.ToInt32(Console.ReadLine());
                    while (altura[contador] <= 0 && altura[contador] >= 300)
                    {
                        Console.WriteLine("Numero Invalido!");
                        Console.Write("Digite sua altura em cm: ");
                        altura[contador] = Convert.ToInt32(Console.ReadLine());
                    }
                    if (maiorAltura >= altura[contador] || sexo[contador] == "M")
                    {
                        maiorAltura = altura[contador];
                        nomeMaiorAltura = nome[contador];
                    }
                }
            }
            mediaIdade = somaIdade / contador;
            Console.WriteLine("O maior aluno foi o " + nomeMaiorAltura + " com a altura de " + maiorAltura + " em cm");
            Console.WriteLine("A aluna mais pesada foi a " + nomeMaiorPeso + " com o peso de " + maiorPeso + " em kg");
            Console.WriteLine("A media de idade dos atletas são: " + mediaIdade);
        }
    }
}
