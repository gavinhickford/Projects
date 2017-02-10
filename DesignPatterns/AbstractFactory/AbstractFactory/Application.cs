using System;

namespace AbstractFactory
{
    public class Application
    {
        private readonly IVacationPartFactory _partFactory;

        public Application(IVacationPartFactory partFactory)
        {
            _partFactory = partFactory;
        }
        public void Run()
        {
            VacationSpecificationBuilder builder =
                new VacationSpecificationBuilder(
                    _partFactory,
                    new DateTime(2017, 7, 7),
                    14,
                    "Falkirk",
                    "Florence");

            builder.SelectHotel("Small One");
            builder.SelectAirplane("Noisy one");
            VacationSpecification spec = builder.BuildVacation();
        }
    }
}
