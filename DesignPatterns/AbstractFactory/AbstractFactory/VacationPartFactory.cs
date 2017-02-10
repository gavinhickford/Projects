using System;

namespace AbstractFactory
{
    public class VacationPartFactory : IVacationPartFactory
    {
        private readonly IHotelService _hotalService;
        private readonly IAirplaneService _airplaneService;

        public VacationPartFactory(
            IHotelService hotelService,
            IAirplaneService airplaneService)
        {
            _hotalService = hotelService;
            _airplaneService = airplaneService;
        }

        public IVacationPart CreateHotelReservation(string town, string hotelName, DateTime arrivalDate, DateTime leaveDate)
        {
            return _hotalService.MakeBooking(
                hotelName,
                arrivalDate,
                leaveDate);
        }

        public IVacationPart CreateFlight(string companyName, string source, string destination, DateTime date)
        {
            return _airplaneService.SelectFlight(
                companyName,
                source,
                destination,
                date);
        }

        public IVacationPart CreateFerryBooking(string lineName, bool fromMainland, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateDailyTrip(string tripName, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IVacationPart CreateMassage(string salon, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
