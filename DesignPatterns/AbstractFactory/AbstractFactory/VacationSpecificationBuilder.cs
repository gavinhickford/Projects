using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class VacationSpecificationBuilder
    {
        private readonly IList<IVacationPart> _parts = new List<IVacationPart>();

        private readonly IVacationPartFactory _partFactory;

        private DateTime _arrivalDate;
        private readonly int _totalNights;
        private readonly string _livingTown;
        private readonly string _destinationTown;


        public VacationSpecificationBuilder(
            IVacationPartFactory partFactory,
            DateTime arrivalDate,
            int totalNights,
            string livingTown,
            string destinationTown)
        {
            _partFactory = partFactory;
            _arrivalDate = arrivalDate;
            _totalNights = totalNights;
            _livingTown = livingTown;
            _destinationTown = destinationTown;
        }

        public VacationSpecification BuildVacation()
        {
            foreach (IVacationPart part in _parts)
            {
                part.Purchase();
            }

            return new VacationSpecification(_parts);
        }

        public void SelectHotel(string hotelName)
        {
            _parts.Add(_partFactory.CreateHotelReservation(
                _destinationTown,
                hotelName,
                _arrivalDate,
                _arrivalDate.AddDays(_totalNights)));
        }

        public void SelectAirplane(string companyName)
        {
            _parts.Add(CreateFlightToDestination(companyName));
            _parts.Add(CreateFlightBack(companyName));
        }

        private IVacationPart CreateFlightBack(string companyName)
        {
            return _partFactory.CreateFlight(
                companyName,
                _destinationTown,
                _livingTown,
                _arrivalDate.AddDays(_totalNights));
        }

        private IVacationPart CreateFlightToDestination(string companyName)
        {
            return _partFactory.CreateFlight(
                companyName,
                _livingTown,
                _destinationTown,
                _arrivalDate);
        }
    }
}
