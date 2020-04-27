using System;

namespace ex24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.Write("Digite um numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.Write("O numero maior é " + n2);
            }
            else
            {
                if (n2 > n1 && n2 > n3)
                {
                    Console.Write("O numero maior é " + n2);
                }
                else
                {
                    Console.Write("O numero maior é " + n3);

                }
            }
            Console.ReadKey();
        }        
    }
}




