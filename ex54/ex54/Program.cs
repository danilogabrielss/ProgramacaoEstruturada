using System;

namespace ex54
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];
            int multiplicador = 0, contador;
            for (contador = 0; contador <= 19; contador++)
            {
                Console.Write("Digite um numero: ");
                numero[contador] = Convert.ToInt32(Console.ReadLine());                
            }
            Console.Write("Digite o multiplicador: ");
            multiplicador = Convert.ToInt32(Console.ReadLine());
            for (contador = 0; contador < 20; contador++)
            {
                numero[contador] *= multiplicador;
                Console.WriteLine("O numero digitado anteriormente multiplicado por " + multiplicador +  " é igual a " + numero[contador]);
            }            
            Console.ReadKey();
        }
    }
}
