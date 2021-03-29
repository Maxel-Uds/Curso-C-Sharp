using System;
using sln_sem_interface.Entities;

namespace sln_sem_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("Modelo do carro: ");
            string name = Console.ReadLine();
            Console.Write("Retirada (DD/MM/AAAA HH:MM): ");
            DateTime pickUp = DateTime.Parse(Console.ReadLine());
            Console.Write("Entrega (DD/MM/AAAA HH:MM): ");
            DateTime retur = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            Console.Write("Valor por dia: ");
            double valuePerDay = double.Parse(Console.ReadLine());

            CarModel model = new CarModel(name);
            Location location = new Location(model, pickUp, retur, valuePerHour, valuePerDay);

            Console.WriteLine();
            Console.WriteLine("RECIBO:");
            Console.WriteLine("Pagamento básico: " + location.Payment().ToString("F2"));
            Console.WriteLine("Taxa: " + location.Tax().ToString("F2"));
            Console.WriteLine("Total: " + location.TotalPayment().ToString("F2"));

        }
    }
}
