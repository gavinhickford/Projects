using System;

namespace AbstractFactory
{
    public class AirplaneService : IAirplaneService
    {
        public IVacationPart SelectFlight(string companyName, string origin, string destination, DateTime travelDate)
        {
            Console.WriteLine($"Selecting flight for {companyName}, from {origin} to {destination} on {travelDate}");
            return new AirplaneFlight();
        }
    }
}
