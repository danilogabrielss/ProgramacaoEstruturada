using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero: ");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
                Console.Write("O numero " + n1 + " é maior");
            else
                if (n2 > n1)
                Console.Write("O numero " + n2 + " é maior");
            else
                 if (n1 == n2)
                Console.Write("Os dois numeros são identicos");
            Console.ReadKey();
        }
    }
}
