using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 1;
            for (int i = 1; i <= 15; i++) {
                Console.Write($" {x}");
                x = y + z;
                z = y;
                y = x;
            }
        }
    }
}
