using System;

namespace pratica
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = int.Parse(Console.ReadLine());
           for (int i = 1; i <= x; i++) {
            double a = Math.Pow(i,2), b = Math.Pow(i,3);
            Console.WriteLine($"{i} {a} {b}");
           }
        }
    }
}
