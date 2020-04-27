using System;

namespace ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, relacao;
            Console.Write("Digite o peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Digite o altura: ");
            altura = double.Parse(Console.ReadLine());
            relacao = peso / (altura * altura);
            if (relacao < 20)
            {
                Console.Write("Abaixo do peso");
            }
            else
            {
                if (20 <= relacao && relacao < 25)
                {
                    Console.Write("Seu peso é ideal");
                }
                else
                {
                    if (25 <= relacao)
                    {
                        Console.Write("Acima do peso");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
