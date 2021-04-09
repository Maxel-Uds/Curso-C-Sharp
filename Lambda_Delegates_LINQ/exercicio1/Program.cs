using System;
using System.IO;
using System.Linq;
using exercicio1.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho até o arquivo: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    double price = double.Parse(line[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            var averagePrice = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Preço médio: " + averagePrice.ToString("F2"));

            var prods = list.Where(p => p.Price < averagePrice).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string item in prods)
            {
                Console.WriteLine(item);
            }
        }
    }
}
