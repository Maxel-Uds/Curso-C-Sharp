using System.Text;
using System;

namespace sln_sem_interface.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return Tax + BasicPayment; }
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine("RECIBO");
            text.AppendLine("Pagamento: " + BasicPayment.ToString("F2"));
            text.AppendLine("Taxa: " + Tax.ToString("F2"));
            text.AppendLine("Total: " + TotalPayment.ToString("F2"));

            return text.ToString();
        }
    }
}