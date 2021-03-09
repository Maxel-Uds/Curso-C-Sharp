using System;
using System.Globalization;

namespace baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CALCULADORA DE EQUAÇÕES DO SEGUNDO GRAU");
            Console.WriteLine("---------------------------------------");
            while (resp == "s") {
                Console.Write("Digite os valores de A, B e C da equação: ");
                String[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture), b = double.Parse(vet[1], CultureInfo.InvariantCulture), c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                Baskara calculadora = new Baskara(a, b, c);
                calculadora.CalcDeltaRaiz();
                Console.WriteLine();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine(calculadora);

                Console.WriteLine();
                Console.Write("Quer calcular a raíz de outra equação (s/n)? ");
                resp = Console.ReadLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
