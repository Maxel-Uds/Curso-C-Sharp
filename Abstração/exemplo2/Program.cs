using System;
using exemplo2.Entities;
using exemplo2.Entities.Enums;
using System.Collections.Generic;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de formas: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shape = new List<Shape>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Forma #{i}:");
                Console.Write("Retângulo ou Círculo (r/c): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto, Azul, Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(resp == 'r')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double heigth = double.Parse(Console.ReadLine());
                    shape.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("ÁREAS:");
            foreach(Shape obj in shape)
            {
                Console.WriteLine(obj.Area().ToString("F2"));
            }
        }
    }
}
