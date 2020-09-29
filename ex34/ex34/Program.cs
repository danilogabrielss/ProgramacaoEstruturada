using System;

namespace ex34
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            Console.Write("Digite o sexo: ");
            sexo = Console.ReadLine();         
            while ((sexo != "M") && (sexo != "F"))
            {
                Console.WriteLine("Sexo invalido!");
                Console.Write("Digite o sexo: ");
                sexo = Console.ReadLine(); 
            }
            Console.WriteLine("Sexo valido.");
            Console.ReadKey();
        }
    }
}
