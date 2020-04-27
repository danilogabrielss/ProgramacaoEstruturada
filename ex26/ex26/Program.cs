using System;

namespace ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            double catetoadjascente, catetooposto, hipotenusa, soma;
            Console.Write("Digite o valor de cateto oposto: ");
            catetooposto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de cateto adjascente: ");
            catetoadjascente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de hipotenusa: ");
            hipotenusa = Convert.ToInt32(Console.ReadLine());
            soma = catetoadjascente + catetooposto;
            if (catetoadjascente == catetooposto && hipotenusa == catetoadjascente && soma > hipotenusa)
            {
                Console.Write("É um triangulo equliatero");
            }
            else
            {
                if (catetooposto != catetoadjascente && catetoadjascente != hipotenusa && hipotenusa != catetooposto && soma > hipotenusa)
                {
                    Console.Write("O triangulo é escaleno");
                }
                else
                {
                    if (catetooposto == hipotenusa || catetoadjascente == hipotenusa || catetoadjascente == catetooposto && soma > hipotenusa)
                    {
                        Console.Write("O triangulo é isoceles");
                    }
                    else
                    {
                        Console.Write("Não é um triangulo");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
