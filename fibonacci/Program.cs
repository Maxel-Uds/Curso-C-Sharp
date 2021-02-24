using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, z = 1;
            Console.Write(y);
            for (int i = 1; i <= 15; i++) {
                x = y + z;
                Console.Write($" {x}");
                z = y;
                y = x;
            }
        }
    }
}
