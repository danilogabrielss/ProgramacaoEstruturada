using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int bases, altura, area ; 
            Console.Write("Digite o valor da base: ");
            bases = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor da altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            area = (bases * altura) / 2 ;
            Console.Write("O valor da area do triangulo é " + area);
            Console.ReadKey();
        }
    }
}
