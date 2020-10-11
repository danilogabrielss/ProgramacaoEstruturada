using System;

namespace ex47
{
    class Program
    {
        static void Main(string[] args)
        {
            string continua = "S";
            do
            {

                Console.Write("Deseja continuar? (S//N): ");
                continua = Console.ReadLine();
            } while (continua == "S");
        }
    }
}
