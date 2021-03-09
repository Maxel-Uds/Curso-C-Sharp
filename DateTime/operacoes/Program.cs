using System;

namespace operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime d5 = new DateTime(2021, 4, 10);
            DateTime d6 = new DateTime(2000, 4, 10);

            DateTime d2 = d1.AddHours(2);
            DateTime d3 = d1.AddMinutes(3);
            DateTime d4 = d1.AddDays(7);
            TimeSpan t = d5.Subtract(d6);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(t);
        }
    }
}
