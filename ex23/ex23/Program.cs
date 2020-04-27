using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex23
{
    class Program
    {
        static void Main(string[] args)
        {
            double arearet, baseret, alturaret;
            Console.Write("Digite o valor da altura do retangulo: ");
            alturaret = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da base do retangulo: ");
            baseret = double.Parse(Console.ReadLine());
            arearet = baseret * alturaret;
            if (arearet > 100)
                Console.Write("Terreno grande");
            else
                Console.Write("Terreno pequeno");
            Console.ReadKey();
        }
    }
}
