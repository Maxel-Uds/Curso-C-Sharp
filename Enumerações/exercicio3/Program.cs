using System;
using exercicio3.Entities;
using exercicio3.Entities.Enums;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Ano de nascimento (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados do pedido:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos itens terá essa ordem? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do item #{i}:");
                Console.Write("Nome do produto: ");
                string name2 = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(name2, price);
                OrderItem item = new OrderItem(quantity, price, product);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO: ");
            Console.WriteLine(order);
        }
    }
}
