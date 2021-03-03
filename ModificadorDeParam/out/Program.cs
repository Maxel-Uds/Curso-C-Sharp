using System;

namespace out1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Triplicar.Triple(a, out triple);
            Console.WriteLine(triple);

        }
    }
}
