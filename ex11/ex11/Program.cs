using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, diametro, raio;
            Console.Write("Digite o tamanho do diametro do circulo: ");
            diametro = double.Parse(Console.ReadLine());
            raio = diametro / 2;
            area = Math.PI*(raio * raio);
            Console.Write("A area do ciruclo é " + area);
            Console.ReadKey();
        }
    }
}
