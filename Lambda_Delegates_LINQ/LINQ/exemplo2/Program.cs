using System;
using System.Linq;
using exemplo2.Entities;
using System.Collections.Generic;

namespace exemplo2
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

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900); //Filtrar
            Print("TIER 1 E PREÇO < 900", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name); //Filtrar e selecionar apenas o nome
            Print("CATEGORIA TOOLS", r2);

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => p.Name + ", " + p.Price.ToString("F2") + ", " + p.Category.Name); //Filtrar e selecionar
            Print("PRODUTOS QUE COMEÇAM COM A LETRA 'C'", r3);

            //Filtrar e ordernar por preço (OrderByDescending = ordem decrescente) e depois por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 E ORDENADO POR PREÇO E DEPOIS POR NOME", r4);

            var r5 = r4.Skip(2).Take(4); //Criar páginação
            Print("TIER 1 E ORDENADO POR PREÇO E DEPOIS POR NOME PULA 2 E PEGA 4", r5);

            var r6 = products.First(); //Mostra o primeiro elemento (FirstOrDefault = se não encontrar nenhum elemento retorna nulo)
            Console.WriteLine("PEGA O PRIMEIRO ELEMENTO");
            Console.WriteLine(r6);

            var r7 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); //Agrega uma operação
            Console.WriteLine("CATEGORIA 1 COM SOMA AGREGADA: " + r7);
            Console.WriteLine();

            var r8 = products.GroupBy(p => p.Category); //Cria grupos
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
