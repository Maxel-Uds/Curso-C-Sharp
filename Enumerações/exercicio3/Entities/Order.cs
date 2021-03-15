using System;
using System.Text;
using System.Collections.Generic;
using exercicio3.Entities.Enums;

namespace exercicio3.Entities
{
    public class Order
    {

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;

        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in Item)
            {
                total = total + item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("Horário da ordem: " + Moment);
            text.AppendLine("Status: " + Status.ToString());
            text.AppendLine("Cliente: " + Client.Name + " " + Client.BirthDate.ToString("dd/MM/yyyy") + " - " + Client.Email);
            text.AppendLine("Itens do pedido:");
            foreach(OrderItem item in Item)
            {
                text.AppendLine(item.Product.Name + ", $" + item.Price.ToString("F2") + ", Quantidade: " + item.Quantity + ", Subtotal: $" + item.SubTotal().ToString("F2"));
            }
            text.AppendLine("Preço total: $" + Total().ToString("F2"));
            return text.ToString();
        }
    }
}