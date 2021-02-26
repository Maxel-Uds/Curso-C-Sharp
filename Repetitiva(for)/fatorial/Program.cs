using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            int x = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = 1; i <= x; i++) {
                fatorial = fatorial * (i);
                }
            Console.WriteLine(fatorial);
        }
    }
}
