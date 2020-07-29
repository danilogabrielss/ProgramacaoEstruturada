using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex29
{
    class Program
    {
        static void Main(string[] args)
        {
            double aceleracao, tempo, vinicial, vms, vkmh;
            Console.Write("Digite o valora da aceleracao: ");
            aceleracao = double.Parse(Console.ReadLine());
            Console.Write("Digite o valora do tempo do percurso: ");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("Digite o valora da velocidade inicial: ");
            vinicial = double.Parse(Console.ReadLine());
            vms = vinicial + aceleracao * tempo;
            vkmh = vms * 3.6;
            if (vkmh <= 40)
            {
                Console.Write("Veículo muito lento");
            }
            else
            {
                if(40 < vkmh && vkmh <= 60)
                {
                    Console.Write("Velociade permitida");
                }
                else
                {
                    if (60 < vkmh && vkmh <= 80)
                    {
                        Console.Write("Velocidade de cruzeiro");
                    }
                    else
                    {
                        if (80 < vkmh && vkmh <= 120)
                        {
                            Console.Write("Veículo rápido");
                        }
                        else
                        {
                            Console.Write("Veículo muito rápido");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
