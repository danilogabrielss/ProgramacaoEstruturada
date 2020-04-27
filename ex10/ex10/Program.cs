using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double tc, tf;
            Console.Write("Digite a temperatura em Fahrenheit: ");
            tf = double.Parse(Console.ReadLine());
            tc = ((tf - 32) / 9) * 5;
            Console.Write("A temperatura é " + tc + " em Celsius");
            Console.ReadKey();
        }
    }
}
