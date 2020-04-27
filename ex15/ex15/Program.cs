using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, cotacao, dolar;
            Console.Write("Digite o valor da cotacão do dolar: ");
            cotacao = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do dolar: ");
            dolar = double.Parse(Console.ReadLine());
            reais = dolar * cotacao;
            Console.Write("O valor em reais é " + reais);
            Console.ReadKey();
        }
    }
}
