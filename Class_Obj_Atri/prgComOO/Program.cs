using System;

namespace prgComOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Triângulo X: " + areaX.ToString("F2"));
            Console.WriteLine("Triângulo Y: " + areaY.ToString("F2"));

            if (areaX > areaY) {
                Console.WriteLine("Maior: X");
            }
            else {
                Console.WriteLine("Maior: Y");
            }
        }
    }
}
