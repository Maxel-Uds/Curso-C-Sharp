using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("Qual o número de valores? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine(printService.First());
        }
    }
}
