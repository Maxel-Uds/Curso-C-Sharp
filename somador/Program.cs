using System;

namespace somador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++) {
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma = valor + soma;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
