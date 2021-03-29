using System;
using sln_sem_interface.Entities;

namespace sln_sem_interface.Services
{
    public class RentalService
    {
        public double ValuePerHour { get; private set; }
        public double ValuePerDay { get; private set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double valuePerHour, double valuePerDay)
        {
            ValuePerHour = valuePerHour;
            ValuePerDay = ValuePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = Math.Ceiling(duration.TotalHours) * ValuePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * ValuePerDay;
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}