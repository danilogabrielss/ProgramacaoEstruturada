using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            double milhamar, km, metros;
            Console.Write("Digite a quantidade milha maritima: ");
            milhamar = double.Parse(Console.ReadLine());
            metros = milhamar * 1852;
            km = metros / 1000;
            Console.Write("A quantidade em quilometros é " + km);
            Console.ReadKey();

        }
    }
}
