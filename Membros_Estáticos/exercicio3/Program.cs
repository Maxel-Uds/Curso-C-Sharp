using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do Dólar? $ ");
            Cotacao.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dólares você vai comprar? R$ ");
            Cotacao.Qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cotacao.TotalAPagar();
            Console.WriteLine("Valor a ser pago em reais: R$ " + Cotacao.Total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
