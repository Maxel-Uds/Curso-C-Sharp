using System;

namespace operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            //Casting feito na linha 13 para indicar que o resultado será um núm quebrado. Ou poderia colocar o 10.0 para deixar explícito que é um double.
            double n4 = (double) 10 / 8;

            //baskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b,2.0)-(4 * a * c);
            double x1 = (-b + Math.Sqrt(delta))/(2 * a);
            double x2 = (-b - Math.Sqrt(delta))/(2 * a);
            //baskara

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine($"O valor de X1 é igual a {x1}, e o valor de X2 é igual a {x2}");
        }
    }
}
