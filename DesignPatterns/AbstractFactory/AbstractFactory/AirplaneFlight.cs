using System;

namespace AbstractFactory
{
    public class AirplaneFlight : IVacationPart
    {
        public void Cancel()
        {
            Console.WriteLine("Cancelling Flight");

        }

        public void Purchase()
        {
            Console.WriteLine("Purchasing Flight");

        }

        public void Reserve()
        {
            Console.WriteLine("Reserving Flight");

        }
    }
}
