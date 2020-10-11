using System;

namespace ex46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int [21];
            int contador, maiorNumero = 0, soma = 0, media = 0, digitar, menorNumero = 0;
            int positivo = 0, negativo = 0, porcentagemPositiva, porcentagemNegativa;
            Console.Write("Digite a quantidade de numeros a ser digitados: ");
            digitar = Convert.ToInt32(Console.ReadLine());
            while (digitar >= 20 || digitar <= 0)
            {
                Console.WriteLine("ERRO! Numero invalido.");
                Console.Write("Digite a quantidade de numeros a ser digitados: ");
                digitar = Convert.ToInt32(Console.ReadLine());
            }
            for (contador = 1; contador <= digitar; contador++)
            {
                Console.Write("Digite o " + contador + " numero: ");
                numero[contador] = Convert.ToInt32(Console.ReadLine());
                if (menorNumero <= numero[contador])
                {
                    menorNumero = numero[contador];
                }
                else
                {
                    menorNumero = numero[contador];
                }
                if (numero[contador] >= 0) 
                {
                    positivo += 1;
                }
                else if (numero[contador] <0)
                {
                    negativo += + 1;
                }
                soma = soma + numero[contador];                
            }
            media = soma / digitar;
            porcentagemPositiva = positivo / digitar * 100;
            porcentagemNegativa = negativo / digitar * 100;
            Console.WriteLine("O maior numero é " + maiorNumero);
            Console.WriteLine("O menor numero é " + menorNumero);
            Console.WriteLine("A soma dos numeros são " + soma);
            Console.WriteLine("A média é " + media);
            Console.WriteLine("A porcentagem de numero positivo é " + porcentagemPositiva + "%");
            Console.WriteLine("A porcentagem de numero negativo é " + porcentagemNegativa + "%");
            Console.ReadKey();
        }
    }
}
