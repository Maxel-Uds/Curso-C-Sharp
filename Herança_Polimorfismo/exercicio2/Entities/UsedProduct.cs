using System;

namespace exercicio2.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $" + Price + " (Produzido em " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}