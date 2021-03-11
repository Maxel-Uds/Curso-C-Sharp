using System;
using exemplo.Entities;
using exemplo.Entities.Enums;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
                
            };

            Console.WriteLine(order);

            //Conversão de enumeração para string
            string txt = OrderStatus.PendingPayment.ToString();
            //Conversão de string para enumeração
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
