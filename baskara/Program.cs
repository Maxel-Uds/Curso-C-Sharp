using System;

namespace baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("CALCULADORA DE EQUAÇÕES DO SEGUNDO GRAU");
            Console.WriteLine("---------------------------------------");
            Console.Write("Digite os valores de A, B e C da equação: ");

            String[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]), b = double.Parse(vet[1]), c = double.Parse(vet[2]);
            double delta = Math.Pow(b,2) - (4 * a * c);
            double x1 = 0.0;
            double x2 = 0.0;

            if (a == 0) {
                Console.WriteLine("A equação digitada não é do segundo grau");
            }
            else if (delta == 0) {
                x1 = (-b + Math.Sqrt(delta))/(2 * a);
                Console.WriteLine("A equação tem delta igual a " + delta + " e duas raízes iguais a " + x1.ToString("F2"));
            }
            else if (delta > 0) {
                x1 = (-b + Math.Sqrt(delta))/(2 * a);
                x1 = (-b - Math.Sqrt(delta))/(2 * a);
                Console.WriteLine("A equação tem delta igual a " + delta + " e duas raízes distintas com X1 igual a " + x1.ToString("F2") + " e X2 igual a " + x2.ToString("F2"));
            }
            else {
                Console.WriteLine("A equação possui delta negativo igual a " + delta + " e não possui raízes no conjunto dos reais.");
            }
        }
    }
}
