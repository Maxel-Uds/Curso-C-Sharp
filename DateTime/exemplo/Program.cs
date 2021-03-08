using System;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2021, 03, 08);
            //Ano, mês, dia, hora, minutos, segundos
            DateTime d3 = new DateTime(2021, 03, 08, 20, 45, 03);
            DateTime d4 = DateTime.Parse("2000-08-15");
            DateTime d5 = DateTime.Parse("2000-08-15 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
        }
    }
}
