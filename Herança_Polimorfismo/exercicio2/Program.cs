using System;
using exercicio2.Entities;
using System.Collections.Generic;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> prods = new List<Product>();

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Comum, usado, importado (c/u/i): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());
                if(resp == 'i')
                {
                    Console.Write("Taxa da alfândega: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    prods.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(resp == 'u')
                {
                    Console.Write("Produzido em (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    prods.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    prods.Add(new Product(name, price));
                }
            }

            foreach(Product obj in prods)
            {
                Console.WriteLine(obj.PriceTag());
            }
        }
    }
}
