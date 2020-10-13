using System;

namespace ex40
{
    class Program
    {
        static void Main(string[] args)
        {
            double anterior = 0, atual = 0, proximo = 1;
            while (atual <= 40)
            {
                Console.WriteLine(anterior + " + " + atual + " = " + proximo);
                anterior = atual;
                atual = proximo;
                proximo = atual + anterior;
            }
        }
    }
}
