using System;

namespace propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t.Days);
            Console.WriteLine(t.TotalDays);
        }
    }
}
