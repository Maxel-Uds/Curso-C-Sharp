using System;
using exemplo2.Entities;
using exemplo2.Entities.Exceptions;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.Write("Quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Data do Check-in (DD/MM/YYYY): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do Check-out (DD/MM/YYYY): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva:");
                Console.Write("Data do Check-in (DD/MM/YYYY): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do Check-out (DD/MM/YYYY): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation); 
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
