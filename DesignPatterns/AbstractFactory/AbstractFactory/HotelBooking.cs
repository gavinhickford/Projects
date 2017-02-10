using System;

namespace AbstractFactory
{
    public class HotelBooking : IVacationPart
    {
        public void Reserve()
        {
            Console.WriteLine("Reserving Hotel");
        }

        public void Purchase()
        {
            Console.WriteLine("Purchasing Hotel Stay");
        }

        public void Cancel()
        {
            Console.WriteLine("Cancelling Hotel Reservation");
        }
    }
}
