using System;

namespace prova_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;
            Console.WriteLine("Digite da sua idade: ");
            idade = double.Parse(Console.ReadLine());
            if (idade < 16)
            {
                Console.WriteLine("Voce nao esta apto a votar");
            }
            else
            {
                if (idade == 16 || idade == 17 )
                {
                    Console.WriteLine("Voce é um eleitor facultativo");
                }
                else
                {
                    if (idade >= 18 && idade <= 70)
                    {
                        Console.WriteLine("Voce é um eleitor obrigatorio");
                    }
                    else
                    {
                        Console.WriteLine("Voce é um eleitor facultativo");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
