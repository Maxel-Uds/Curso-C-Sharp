using System;
using System.Globalization;
using sln_com_interface.Entities;
using sln_com_interface.Services;

namespace sln_com_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Retirada (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entrega (DD/MM/AAAA HH:MM): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",  CultureInfo.InvariantCulture);
            Console.Write("Valor por hora: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            Console.Write("Valor por dia: ");
            double valuePerDay = double.Parse(Console.ReadLine());

            CarRental rental = new CarRental(start, finish, new CarModel(model));
            RentalService rentalService = new RentalService(valuePerHour, valuePerDay, new BrazilTaxService());
            rentalService.ProcessInvoice(rental);

            Console.WriteLine();
            Console.WriteLine(rental.Invoice);

        }
    }
}
