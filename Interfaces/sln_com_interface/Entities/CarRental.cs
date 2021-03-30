using System;

namespace sln_com_interface.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Invoice Invoice { get; set; }
        public CarModel Model { get; set; }

        public CarRental(DateTime start, DateTime finish, CarModel model)
        {
            Start = start;
            Finish = finish;
            Invoice = null;
            Model = model;
        }
    }
}