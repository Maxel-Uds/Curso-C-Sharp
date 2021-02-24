using System;

namespace raizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double n1 = 0;
            while (x >= 0) {
                Console.Write("Digite um número: ");
                x = int.Parse(Console.ReadLine());
                if ( x >= 0) {
                n1 = Math.Sqrt(x);
                Console.WriteLine(n1.ToString("F3"));
                }
            }
            Console.WriteLine("Número negativo");
        }
    }
}
