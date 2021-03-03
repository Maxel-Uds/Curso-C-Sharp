using System;

namespace refs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Triplicar.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
