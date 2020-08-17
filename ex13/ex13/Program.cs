using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            double vf, vi, aceleracao, tempo, ms;
            Console.Write("Digite a velocidade incial (em m/s): ");
            vi = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da aceleracao: ");
            aceleracao = double.Parse(Console.ReadLine());
            Console.Write("Digite o tempo (em segundos): ");
            tempo = double.Parse(Console.ReadLine());
            ms = (tempo * aceleracao) + tempo ;
            vf = ms * 3.6;
            Console.Write("A velociade final é " + vf +  " (em km/h)");
            Console.ReadKey();
        }
    }
}
