using System;

namespace AbstractFactory
{
    public class HotelService : IHotelService
    {
        public IVacationPart MakeBooking(string hotelName, DateTime checkin, DateTime checkout)
        {
            Console.WriteLine($"Making booking for {hotelName}, checking in on {checkin} and checking out on {checkout}");
            return new HotelBooking();
        }
    }
}
