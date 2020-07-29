using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1, p2, sobra;
            Console.WriteLine("Digite o valor de P1: ");
            p1 = Convert.ToInt32(Console.ReadLine());
            sobra = 15 - p1 ;
            p2 = sobra / 2;
            Console.WriteLine("A nota de P2 precisa ser " + p2);
            Console.ReadKey();
        }
    }
}
