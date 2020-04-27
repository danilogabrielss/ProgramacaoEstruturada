using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, vfinal;
            Console.Write("Digite o valor de X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            Y = double.Parse(Console.ReadLine());
            vfinal = Math.Pow (X , Y);
            Console.Write("O valor de X elevado a Y é " + vfinal);
            Console.ReadKey();
        }
    }
}
