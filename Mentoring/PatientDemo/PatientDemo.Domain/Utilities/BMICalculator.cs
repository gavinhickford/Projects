using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.Domain.Utilities
{
    internal static class BMICalculator
    {
        internal static float Calculate(float height, float weight)
        {
            return weight / (height * height);
        }
    }
}
