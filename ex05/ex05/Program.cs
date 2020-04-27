using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            double diametro, raio, area;
            Console.Write("Digite o tamanho do diametro da esfera: ");
            diametro = double.Parse(Console.ReadLine());
            raio = diametro / 2;
            area = (4 * Math.PI * (raio * raio * raio)) / 3;
            Console.Write("O volume é da esfera é " + area);
            Console.ReadKey();
        }
    }
}
