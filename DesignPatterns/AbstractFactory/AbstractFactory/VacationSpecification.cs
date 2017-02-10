using System.Collections.Generic;

namespace AbstractFactory
{
    public class VacationSpecification
    {
        private readonly IList<IVacationPart> _parts;

        public VacationSpecification(IList<IVacationPart> parts)
        {
            _parts = parts;
        }
    }
}