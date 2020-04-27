using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo, sen, cos, tan;
            Console.Write("Digite o angulo em graus: ");
            angulo = double.Parse(Console.ReadLine());
            sen = Math.Sin(angulo);
            cos = Math.Cos(angulo);
            tan = Math.Tan(angulo);
            Console.Write("O valor em seno, cosseno e tnagente é respectivamente: " + sen + "; " + cos + "; " + tan);
            Console.ReadKey();
        }
    }
}
