using System;
using exemplo1.Services;

namespace exemplo1
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);

            Console.WriteLine(result);
        }
    }
}
