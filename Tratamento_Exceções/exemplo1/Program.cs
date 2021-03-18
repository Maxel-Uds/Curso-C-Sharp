using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e) {
                Console.WriteLine("Erro! " + e.Message);
            }
            catch(FormatException) {
                Console.WriteLine("Dado inválido!");
            }
        }
    }
}
