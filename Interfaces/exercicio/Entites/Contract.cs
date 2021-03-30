using System;
using System.Text;
using System.Collections.Generic;

namespace exercicio.Entites
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void RemoveInstallment(Installment inst)
        {
            Installments.Remove(inst);
        }

        public void AddInstallment(Installment inst)
        {
            Installments.Add(inst);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("PARCELAS:");
            foreach(Installment install in Installments)
            {
                text.AppendLine(install.DueDate.ToString("dd/MM/yyyy") + " - " + install.Amount.ToString("F2"));
            }

            return text.ToString();
        }
    }
}