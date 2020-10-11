using System;

namespace ex41
{
    class Program
    {
        static void Main(string[] args)
        {
            double anterior = 1, anterior1 = 1, atual = 1, proximo = 1;
            while (atual <= 40)
            {
                Console.WriteLine(anterior + " + " + anterior1 + " + " + atual + " = " + proximo);
                anterior1 = anterior;
                anterior = atual;
                atual = proximo;
                proximo = atual + anterior + anterior1;
            }
        }
    }
}
