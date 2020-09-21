using System;

namespace prova_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double etiqueta, pagamento;
            Console.WriteLine("Digite o valor da etiqueta: ");
            etiqueta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite 1 para a vista em dinheiro ou cheque com 15% de desconto");
            Console.WriteLine("Digite 2 para á vista no cartão de crédito, recebe 5% de desconto ");
            Console.WriteLine("Digite 3 para em duas vezes, no cartão de crédito, sem juros.");
            Console.WriteLine("Digite 4 para em três vezes, no cartão de crédito, juros de 10% "); 
            Console.WriteLine("Digite de que forma ira ser o pagamento: ");
            pagamento = double.Parse(Console.ReadLine());
            switch(pagamento)
            {
                case 1:
                    etiqueta = etiqueta * 0.85;
                    Console.WriteLine("O valor a ser pago será R$"+ etiqueta);
                    break;
                case 2:
                    etiqueta = etiqueta * 0.95;
                    Console.WriteLine("O valor a ser pago será R$" + etiqueta);
                    break;
                case 3:
                    etiqueta = etiqueta / 2;
                    Console.WriteLine("O valor a ser pago será duas vezes de R$" + etiqueta);
                    break;
                case 4:
                    etiqueta = (etiqueta * 1.10) /3;
                    Console.WriteLine("O valor a ser pago será tres vezes de R$" + etiqueta);
                    break;
                default:
                    Console.WriteLine("Voce digitou um numero errado!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
