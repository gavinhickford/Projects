using System;

namespace AbstractFactory
{
    public interface IHotelService
    {
        IVacationPart MakeBooking(
            string hotelName, DateTime checkin, DateTime checkout);
    }
}
