using System;

namespace sln_sem_interface.Entities
{
    public class Location
    {
        public CarModel Model { get; set; }
        public DateTime PickUp { get; set; }
        public DateTime Return { get; set; }
        public double ValuePerHour { get; set; }
        public double ValuePerDay { get; set; }


        public Location(CarModel model, DateTime pickUp, DateTime retur, double valuePerHour, double valuePerDay)
        {
            Model = model;
            PickUp = pickUp;
            Return = retur;
            ValuePerHour = valuePerHour;
            ValuePerDay = ValuePerDay;
        }

        public TimeSpan Duration()
        {
            return Return - PickUp;
        }

        public double Payment()
        {
            if(Duration().Hours <= 12)
            {
                return Duration().Hours * ValuePerHour;
            }
            else
            {
                return Duration().Days * ValuePerDay;
            }
        }

        public double Tax()
        {
            if(Payment() <= 100.00)
            {
                return (Payment() * 0.2);
            }
            else
            {
                return (Payment() * 0.15);
            }
        }

        public double TotalPayment()
        {
            if(Payment() <= 100.00)
            {
                return Payment() + (Payment() * 0.2);
            }
            else
            {
                return Payment() + (Payment() * 0.15);
            }
        }
    }
}