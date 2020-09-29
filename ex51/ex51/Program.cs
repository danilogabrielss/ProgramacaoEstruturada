using System;

namespace ex51
{
    class Program
    {
        static void Main(string[] args)
        {
            double escolha, resultado;
            string continua = "S";
            while (continua == "S")
            {
                Console.WriteLine("1 – Triângulo\n2 – Quadrado\n3 – Retângulo\n4 – Círculo\n5 – Fim de processo");
                Console.Write("Digite o a escolha:");
                escolha = double.Parse(Console.ReadLine());                
                switch (escolha)
                {
                    case 1:
                        double baset, altura;
                        Console.Write("Digite o valor da base: ");
                        baset = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do triangulo: ");
                        altura = double.Parse(Console.ReadLine());
                        resultado = (baset * altura) / 2;
                        Console.Write("O valor da area do triangulo é: " + resultado + "\n");
                        break;
                    case 2:
                        double lado;
                        Console.Write("Digite o valor da lateral do quadrado: ");
                        lado = double.Parse(Console.ReadLine());
                        resultado = lado * lado;
                        Console.Write("O valor da area do quadrado é: " + resultado + "\n");
                        break;
                    case 3:
                        double comprimento, largura;
                        Console.Write("Digite o valor do comprimento: ");
                        comprimento = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do largura: ");
                        largura = double.Parse(Console.ReadLine());
                        resultado = comprimento * largura;
                        Console.Write("O valor da area do retangulo é " + resultado + "\n");
                        break;
                    case 4:
                        double raio;
                        Console.Write("Digite o valor do raio: ");
                        raio = double.Parse(Console.ReadLine());
                        resultado = 2 * Math.PI * raio;
                        Console.Write("O valor da area do círculo é " + resultado + "\n");
                        break;
                    default:
                        Console.Write("Número Invalido");
                        break;
                    case 5:
                        Console.Write("Fim do processo");
                        break;
                }
                escolha = 0;
                Console.Write("Deseja continuar (S//N): ");
                continua = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
