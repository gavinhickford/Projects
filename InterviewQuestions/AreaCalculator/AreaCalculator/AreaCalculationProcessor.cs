using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{

    public class AreaCalculationProcessor
    {
        // To cater for different types of shape, w is the width of the square or rectangle,
        // h is the height - used by the rectangle, and r is the radius of a circle
        // Once calculated derive a report based on the requested report type

        public double CalculateArea(string shapeType, int w, int h, double r, string reportType)
        {
        
            // a will hold the area of the shape
            double a = 0;
            //Shape type will determine thre type of calculation to use 
            switch (shapeType)
            {
            
                // If it's a square then multiply the width by itself
                case "Square":
                    a = w * w;

                    // Now generate the report depnding on the requested type
                    if (reportType == "csv")
                    {
                        // Generate a CSV report
                        this.GenerateCsvReportForArea(shapeType, a);
                    }

                    else if (reportType == "pdf")
                        // Generate a PDF report
                        this.GeneratePdfReportForArea(shapeType, a);
                    else
                    {
                        // Default report will be to write to the console
                        Console.WriteLine("Area of the" + shapeType + "is" + a);
                    }
                    break;
                // If it's a rectangle then multiply width by height 
                case "Rectangle":
                    a = w * h;
                    if (reportType == "csv")
                    {
                        // Generate a CSV report
                        this.GenerateCsvReportForArea(shapeType, a);
                    }
                    else if (reportType == "pdf")
                    {
                        // Generate a PDF report
                        this.GeneratePdfReportForArea(shapeType, a);
                    }
                    else
                    {
                        Console.WriteLine("Area of the" + shapeType + "is" + a);
                    }
                    break;
                // Circle is more complicated - pi times radius squared
                case "Circle":
                    //a = 2 * Math.PI * r; -- Incorrectly added the wrong calculation - corrected on 12/08/2018  
                    a = Math.PI * r * r;
                    if (reportType == "csv")
                    {
                        // Generate a CSV report
                        this.GenerateCsvReportForArea(shapeType, a);
                    }

                    else if (reportType == "pdf")
                    {
                        // Generate a PDF report
                        this.GeneratePdfReportForArea(shapeType, a);
                    }
                    else
                    {
                        Console.WriteLine("Area of the" + shapeType + "is" + a);
                    }
                    break;
            }


            return a;
        }
        
        
        
        // Method to calculate the circumference of a shape
        public double CalculateCircumference(string shapeType, int w, int h, double r, string reportType)
        {
            // a will hold the area of the shape
            double c = 0;
            switch (shapeType)
            {
                // If it's a square then multiply the width by itself
                case "Square":
                    c = w + w + w + w;
                    if (reportType == "csv")
                        // Generate a CSV report
                        this.GenerateCsvReportForCircumference(shapeType, c);
                    else if (reportType == "pdf")
                    {
                        // Generate a PDF report
                        this.GeneratePdfReportForCirumference(shapeType, c);
                    }
                    else
                    {
                        Console.WriteLine("Circumference of the" + shapeType + "is" + c);
                    }
                    break;
                // If it's a rectangle then multiply width by height 
                case "Rectangle":
                    c = w + w + h + h;
                    if (reportType == "csv")
                    {
                        // Generate a CSV report
                        this.GenerateCsvReportForCircumference(shapeType, c);
                    }
                    else if (reportType == "pdf")
                    {
                        // Generate a PDF report
                        this.GeneratePdfReportForCirumference(shapeType, c);
                    }
                    else
                    {
                        Console.WriteLine("Circumference of the" + shapeType + "is" + c);
                    }
                    break;
                // Circle is more complicated - pi times radius squared
                case "Circle":
                    c = 2 * Math.PI * r;
                    if (reportType == "csv")
                    {
                        // Generate a CSV report
                        this.GenerateCsvReportForCircumference(shapeType, c);
                    }
                    else if (reportType == "pdf")
                    {
                        // Generate a PDF report
                        this.GeneratePdfReportForCirumference(shapeType, c);
                    }
                    else
                    {
                        Console.WriteLine("Circumference of the" + shapeType + "is" + c);
                    }
                    break;
            }

            return c; 
        }

        // Method to generate the csv report displaying the area of the shape
        private void GenerateCsvReportForArea(string shapeType, double area)
        {
            // CSV report generation code to be completed
            Console.WriteLine("csv report generation still to be completed");
        }

        // Method to generate the pdf report displaying the area of the shape
        private void GeneratePdfReportForArea(string shapeType, double area)
        {
            // PDF report generation code to be completed
            Console.WriteLine("pdf report generation still to be completed");
        }

        // Method to generate the pdf report displaying the circumference of the shape
        private void GeneratePdfReportForCirumference(string shapeType, double circumference)
        {
            // CSV report generation code to be completed
            Console.WriteLine("csv report generation still to be completed");
        }

        // Method to generate the csv report displaying the circumference of the shape
        private void GenerateCsvReportForCircumference(string shapeType, double circumference)
        {
            // PDF report generation code to be completed
            Console.WriteLine("pdf report generation still to be completed");
        }
    }
}
