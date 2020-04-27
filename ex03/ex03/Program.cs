using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            double diagonal, area, aresta;
            Console.Write("Digite o valor da diagonal do quadrado: ");
            diagonal = Convert.ToInt32(Console.ReadLine());
            aresta = Math.Sqrt((diagonal * diagonal) / 2);
            area = aresta * aresta;
            Console.Write("A area do quadrado é " + area);
            Console.ReadLine();
        }
    }
}
