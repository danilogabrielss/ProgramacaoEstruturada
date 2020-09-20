using System;

namespace ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;            
            Console.WriteLine("Digite um numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 < n1)
            {
                Console.WriteLine("Este numero tem que ser maior que o outro!");
                Console.WriteLine("Digite outro numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
