using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            double tensao, corrente, resistencia;
            Console.Write("Digite o valor da resistencia do circuito: ");
            resistencia = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da corrente do circuito: ");
            corrente = double.Parse(Console.ReadLine());
            tensao = corrente * resistencia;
            Console.WriteLine("O valor da tensao no circuito é " + tensao);
            Console.ReadKey();
        }
    }
}
