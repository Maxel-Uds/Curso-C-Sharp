using System;
using _action.Entities;
using System.Collections.Generic;

namespace _action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(UpdatePrice);

            foreach(Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void UpdatePrice(Product p)
        {
            p.Price = p.Price * 1.10;
        }
    }
}
