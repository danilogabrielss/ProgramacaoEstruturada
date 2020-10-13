using System;

namespace ex49
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal contador, resultado1 = 1, total;
            decimal resultado = 1;
            for (contador = 1; contador < 6; contador++)
            {
                resultado1 = contador * resultado1;
            }
            total = resultado / resultado1;
            for (contador = 1; contador < 60; contador++)
            {
                resultado = (contador * resultado);
            }
            
            Console.WriteLine("A quantidade de jogos que precisa ser feita é igual a " + total);
            Console.ReadKey();
        }
    }
}
