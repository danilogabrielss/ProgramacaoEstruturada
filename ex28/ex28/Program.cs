using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex28
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, relacao;
            string sexo;
            Console.Write("Digite o seu sexo F / M: ");
            sexo = Console.ReadLine();
            Console.Write("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());
            relacao = peso / (altura * altura);
            if (sexo == "f" && relacao < 19 )
            {
                Console.Write("Abaixo do peso");
            }
            else
            {
                if (sexo == "f" && 19 <= relacao && relacao < 24)
                {
                    Console.Write("Peso Ideal");
                }
                else
                {
                    if (sexo == "f" && relacao >= 24)
                    {
                        Console.Write("Acima do peso");
                    }
                    else
                    {
                        if (sexo == "m" && relacao < 20)
                        {
                            Console.Write("Abaixo do peso");
                        }
                        else
                        {
                            if (sexo == "m" && 20 <= relacao && relacao < 25)
                            {
                                Console.Write("Peso ideal");
                            }
                            else
                            {
                                if (sexo =="m" && relacao >= 25)
                                {
                                    Console.Write("Acima do peso");
                                }
                                else
                                {
                                    Console.Write("Sexo nao encotrado");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
