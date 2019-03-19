using AreaCalculator;
using System;

namespace AreaCalculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter the type of shape");
            string s = Console.ReadLine();
            string w = string.Empty;
            string h = string.Empty;
            string r = string.Empty;

            if (s == "Square" || s == "Rectangle")
            {
                Console.WriteLine("Please enter the width of the square");
                w = Console.ReadLine();
            }

            if (s == "Rectangle")
            {
                Console.WriteLine("Please enter the height of the rectangle");
                h = Console.ReadLine();
            }

            if (s == "Circle")
            {
                Console.WriteLine("Please enter the radius of the circle");
                r = Console.ReadLine();
            }

            Console.WriteLine("What sort of report would you like?");
            string reportType = Console.ReadLine();

            int width = 0;
            int height = 0;
            double radius = 0;
            Int32.TryParse(w, out width);
            Int32.TryParse(h, out height);
            Double.TryParse(r, out radius);

            var processor = new AreaCalculationProcessor();
            double a = processor.CalculateArea(s, width, height, radius, reportType);
            Console.WriteLine("Area = " + a);
            double c = processor.CalculateCircumference(s, width, height, radius, reportType);
            Console.WriteLine("Circumference = " + c);

            Console.ReadLine();
        }
    }
}
