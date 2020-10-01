using System;

namespace ex38
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1, resultado, tabuada = 1;
            string teste;
            while (tabuada <= 20)
            {
                contador = 1;
                do
                {
                    resultado = tabuada * contador;
                    Console.WriteLine(tabuada + " x " + contador + " = " + resultado);
                    contador = contador + 1;
                } while (contador <= 10);
                teste = Console.ReadLine();
                tabuada = tabuada + 1;
            }
            Console.ReadKey();
        }
    }
}
