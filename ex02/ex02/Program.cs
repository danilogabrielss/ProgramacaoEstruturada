using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, area;
            Console.Write("Digite o tamanho do quadrado: ");
            lado = Convert.ToInt32(Console.ReadLine());
            area = lado * 2;
            Console.Write("A area do quadrado é "+ area);
            Console.ReadKey();
        }
    }
}
