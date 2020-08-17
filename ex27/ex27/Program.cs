using System;

namespace ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            double catetooposto, catetoadj, hipo, somacat, quadhip;
            Console.Write("Digite o valor de A: ");
            catetoadj = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            catetooposto = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            hipo = double.Parse(Console.ReadLine());
            quadhip = hipo * hipo;
            somacat = (catetooposto * catetooposto) + (catetoadj * catetoadj);
            if (somacat == quadhip)
            {
                Console.Write("É um triangulo retangulo");
            }
            else
            {
                Console.Write("Não é um triangulo retangulo");
            }
            Console.Read();
        }
    }
}
