using System;

namespace ex50
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, resultado = 0, escolha;
            string continua = "S";
            Console.Write("Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = double.Parse(Console.ReadLine());
            while (continua == "S")
            {
                Console.WriteLine("Digite 1 para realizar uma multiplicacão");
                Console.WriteLine("Digite 2 para realizar uma adicão");
                Console.WriteLine("Digite 3 para realizar uma divisão");
                Console.WriteLine("Digite 4 para realizar uma subtracão");
                Console.WriteLine("Digite 5 para terminar o processo");
                
                escolha = double.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        resultado = n1 * n2;
                        Console.WriteLine("O resultado de " + n1 + " x " + n2 + " = " + resultado);
                        break;
                    case 2:
                        resultado = n1 + n2;
                        Console.WriteLine("O resultado de " + n1 + " + " + n2 + " = " + resultado);
                        break;
                    case 3:
                        resultado = n1 / n2;
                        Console.WriteLine("O resultado de " + n1 + " / " + n2 + " = " + resultado);
                        break;
                    case 4:
                        resultado = n1 - n2;
                        Console.WriteLine("O resultado de " + n1 + " - " + n2 + " = " + resultado);
                        break;
                    default:
                        Console.Write("Numero invalido.\n");
                        break;
                }
                Console.WriteLine("Deseja continuar ? (S//N)");
                continua = Console.ReadLine();
                Console.Clear();
            }          
        }
    }
}
