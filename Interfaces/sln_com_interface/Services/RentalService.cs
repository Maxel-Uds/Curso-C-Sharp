using System;
using sln_com_interface.Entities;

namespace sln_com_interface.Services
{
    public class RentalService
    {
        public double ValuePerHour { get; private set; }
        public double ValuePerDay { get; private set; }
        private ITaxService _taxService;

        public RentalService(double valuePerHour, double valuePerDay, ITaxService taxService)
        {
            ValuePerHour = valuePerHour;
            ValuePerDay = ValuePerDay;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}