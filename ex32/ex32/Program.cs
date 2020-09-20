using System;
using System.Runtime.InteropServices.ComTypes;

namespace ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorfinal,contador;
            int c = 0 ;        
            Console.WriteLine("Digite o valor do seu contador: ");
            contador = Convert.ToInt32(Console.ReadLine());

            if (contador <= 0) ;
            {
                Console.WriteLine("Numero invalido!");
                Console.WriteLine("Digite o valor do seu contador: ");
                contador = Convert.ToInt32(Console.ReadLine());
            }            
            Console.WriteLine("Até quanto irá o contador: ");
            contadorfinal = Convert.ToInt32(Console.ReadLine());
            if (contadorfinal <= contador);
            {
                Console.WriteLine("Numero invalido!");
                Console.WriteLine("Até quanto irá o contador: ");
                contadorfinal = Convert.ToInt32(Console.ReadLine());
            }
            for (c = contador; contador <= contadorfinal ; contador = contador + 1)
            {
                Console.WriteLine(contador);
            }
            Console.ReadKey();
        }
    }
}
