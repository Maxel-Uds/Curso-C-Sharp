using sln_sem_interface.Entities;

namespace sln_sem_interface.Services
{
    public class RentalService
    {
        public double ValuePerHour { get; private set; }
        public double ValuePerDay { get; private set; }

        public RentalService(double valuePerHour, double valuePerDay)
        {
            ValuePerHour = valuePerHour;
            ValuePerDay = ValuePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}