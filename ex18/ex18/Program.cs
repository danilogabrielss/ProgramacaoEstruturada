using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, pagar, troco;
            Console.Write("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            n3 = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            n4 = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor: ");
            n5 = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor referente ao pagamento da somatória destes valores: ");
            pagar = double.Parse(Console.ReadLine());
            troco = pagar - (n1 + n2 + n3 + n4 + n5);
            Console.Write("O troco da somatoria é " + troco);
            Console.ReadKey();
        }
    }
}
