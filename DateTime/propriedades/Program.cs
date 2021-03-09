using System;

namespace propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine(d.Date);
            Console.WriteLine(d.Day);
            Console.WriteLine(d.DayOfWeek);
            Console.WriteLine(d.DayOfYear);
        }
    }
}
