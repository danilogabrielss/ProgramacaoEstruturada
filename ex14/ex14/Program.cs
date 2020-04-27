using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double vl, ve, vc, raio, aresta;
            Console.Write("Digite o valor do raio da esfera: ");
            raio = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da aresta do cubo: ");
            aresta = double.Parse(Console.ReadLine());
            vc = aresta * aresta * aresta;
            ve = (4 / 3) * Math.PI * raio;
            vl = vc - ve;
            Console.Write("O valor livre entre o cubo e a aresta é " + vl);
            Console.ReadKey();
         }
    }
}
