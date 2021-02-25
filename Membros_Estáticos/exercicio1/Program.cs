using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura e altura do retângulo: ");
            double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = Retangulo.Area(Largura, Altura);
            double per = Retangulo.Perimetro(Largura, Altura);
            double dia = Retangulo.Diagonal(Largura, Altura);

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + per.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + dia.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
