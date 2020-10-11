using System;

namespace ex45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[11];
            int contador, maior_numero = 0, soma = 0, media = 0;
            for (contador = 1; contador <= 10; contador++)
            {
                Console.Write("Digite o " + contador + " numero: ");
                numero[contador] = Convert.ToInt32(Console.ReadLine());
                if (maior_numero <= numero[contador])
                {
                    maior_numero = numero[contador];
                }
                soma = soma + numero[contador];
                media = soma / 10;
            }
            Console.WriteLine("O maior numero é " + maior_numero);
            Console.WriteLine("A soma dos numeros são " + soma);
            Console.WriteLine("A média é " + media);
            Console.ReadKey();
        }
    }
}
