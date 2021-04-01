using System;
using exemplo2.Services;
using exemplo2.Entities;
using System.Collections.Generic;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de produtos a serem inseridos: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();
            for(int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(',');
                string name = vet[0];
                double price = double.Parse(vet[1]);
                list.Add(new Product(name, price));
            }

            CalculationService calc = new CalculationService();

            Console.WriteLine("Maior:");
            Console.WriteLine(calc.Max(list));
        }
    }
}
