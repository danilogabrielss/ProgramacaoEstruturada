using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20
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
            if (n1 < n2)
                Console.Write("O numero " + n1 + " é menor");
            else
                Console.Write("O numero  " + n2 + " é menor");
            Console.ReadKey();
        }
    }
}
