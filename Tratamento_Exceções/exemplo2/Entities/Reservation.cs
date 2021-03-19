using System;
using System.Text;
using exemplo2.Entities.Exceptions;

namespace exemplo2.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if(checkOut <= checkIn)
            {
                throw new DomainExceptions("Erro na reserva: O check-in não pode ser posterior ao check-out.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                throw new DomainExceptions("Erro na reserva: A atualização de datas deve ser para datas futuras.");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainExceptions("Erro na reserva: O check-in não pode ser posterior ao check-out.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append("Reserva: Quarto " + RoomNumber + ", check-in: " + CheckIn.ToString("dd/MM/yyyy") + ", check-out: ");
            text.AppendLine(CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " noites.");
            return text.ToString();
        }
    }
}