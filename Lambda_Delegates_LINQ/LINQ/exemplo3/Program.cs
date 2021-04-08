using System;
using System.Linq;
using exemplo3.Entities;
using System.Collections.Generic;

namespace exemplo3
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>()
            {
                new Product(1, "Computer", 1100.00, c2),
                new Product(2, "Hammer", 90.00, c1),
                new Product(3, "TV", 1700.00, c3),
                new Product(4, "Notebook", 1300.00, c2),
                new Product(5, "Saw", 80.00, c1),
                new Product(6, "Tablet", 700.00, c2),
                new Product(7, "Camera", 700.00, c3),
                new Product(8, "Printer", 350.00, c3),
                new Product(9, "MacBook", 1800.00, c2),
                new Product(10, "Sound Bar", 700.00, c3),
                new Product(11, "Level", 70.00, c1)
            };

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            var r1 = from p in products where p.Category.Tier == 1 && p.Price < 900.0 select p; //LINQ com notação similar ao SQL
            Print("TIER 1 E PREÇO < 900", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print("CATEGORIA TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => p.Name + ", " + p.Price.ToString("F2") + ", " + p.Category.Name);
            var r3 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("PRODUTOS QUE COMEÇAM COM A LETRA 'C'", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print("TIER 1 E ORDENADO POR PREÇO E DEPOIS POR NOME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4 select p).Skip(2).Take(4); //Método usado para funções especiais (coloca-se a função terminal no fim = .Function)
            Print("TIER 1 E ORDENADO POR PREÇO E DEPOIS POR NOME PULA 2 E PEGA 4", r5);

            //var r8 = products.GroupBy(p => p.Category); 
            var r8 = from p in products group p by p.Category; 
            foreach(IGrouping<Category, Product> group in r8)
            {
                Console.WriteLine("Categoria: " + group.Key.Name + ":");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
