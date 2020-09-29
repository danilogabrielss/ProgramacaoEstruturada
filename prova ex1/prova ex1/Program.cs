using System;

namespace prova_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "S";
            while (continuar == "S")
            {                
                Console.WriteLine("Digite da sua idade: ");                
                double idadeValidada;
                bool campoValido = false;
                campoValido = double.TryParse(Console.ReadLine(), out idadeValidada);

                if (campoValido)
                {
                    Console.WriteLine("Campo valido idade = " + idadeValidada);
                } else
                {
                    Console.WriteLine("Erro ao validar campo");
                }

                if (idadeValidada < 16)
                {
                    Console.WriteLine("Voce nao esta apto a votar");
                }
                else
                {
                    if (idadeValidada == 16 || idadeValidada == 17)
                    {
                        Console.WriteLine("Voce é um eleitor facultativo");
                    }
                    else
                    {
                        if (idadeValidada >= 18 && idadeValidada <= 70)
                        {
                            Console.WriteLine("Voce é um eleitor obrigatorio");
                        }
                        else
                        {
                            Console.WriteLine("Voce é um eleitor facultativo");
                        }
                    }
                }
                Console.WriteLine("Deseja continuar: (S//N)");
                continuar = Console.ReadLine();                
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
