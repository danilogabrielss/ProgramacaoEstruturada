using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseret, alturaret, arearet;
            Console.Write("Digite a base do retangulo: ");
            baseret = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a altura do retangulo: ");
            alturaret = Convert.ToInt32(Console.ReadLine());
            arearet = baseret * alturaret;
            Console.WriteLine("A area do retangulo é " + arearet);
            Console.ReadKey();
        }
    }
}
