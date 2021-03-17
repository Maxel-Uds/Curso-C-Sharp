namespace exercicio2.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price; 
        }

        public override string PriceTag()
        {
            TotalPrice();
            return base.PriceTag() + " (Taxa da alfândega " + CustomsFee.ToString("F2") + ")";
        }
    }
}