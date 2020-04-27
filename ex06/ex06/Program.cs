using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, media;
            Console.Write("Digie um numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digie um numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digie um numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digie um numero: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            Console.Write("A media entre os numeros é " + media);
            Console.ReadKey();
        }
    }
}
