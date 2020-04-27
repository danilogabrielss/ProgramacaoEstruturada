using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite um numero: ");
            n2 = double.Parse(Console.ReadLine());
            media = Math.Sqrt(n1 * n2);
            Console.Write("A media geometrica é " + media);
            Console.ReadKey();
        }
    }
}
