using System.Text;

namespace exercicio2.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder tag = new StringBuilder();
            tag.Append(Name + " $" + Price.ToString("F2"));
            return tag.ToString();
        }
    }
}