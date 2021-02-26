using System;

namespace funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("O maior número é igual a "+ Maior.Teste(a, b, c));
        }
    }
}
