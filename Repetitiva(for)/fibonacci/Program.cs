using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {   
            Fibonacci.X = 0; Fibonacci.Y = 0; Fibonacci.Z = 1;
            for (int i = 1; i <= 15; i++) {
                Console.Write(Fibonacci.Sequecia() + " ");
                Fibonacci.Soma();
            }
        }
    }
}
