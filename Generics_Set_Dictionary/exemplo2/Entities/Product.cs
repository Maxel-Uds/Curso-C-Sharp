using System;
using System.Text;

namespace exemplo2.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(Name + ", " + Price.ToString("F2"));
            return text.ToString();
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("O argumento não é um produto!");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}