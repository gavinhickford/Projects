using System;

namespace AbstractFactory
{
    public interface IAirplaneService
    {
        IVacationPart SelectFlight(
            string companyName,
            string origin,
            string destination,
            DateTime travelDate);
    }
}
