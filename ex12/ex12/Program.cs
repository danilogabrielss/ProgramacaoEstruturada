using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, volume, raiobase;
            Console.Write("Digite o valor da altura do cone: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da raio da base do cone: ");
            raiobase = double.Parse(Console.ReadLine());
            volume = (Math.PI * raiobase * raiobase * altura) / 3;
            Console.Write("O volume do cone é " + volume);
            Console.ReadKey();
        }
    }
}
