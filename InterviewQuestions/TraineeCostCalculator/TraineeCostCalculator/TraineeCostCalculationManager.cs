using System;
using System.Collections.Generic;
using System.Text;

namespace TraineeCostCalculator
{
    public class TraineeCostCalculationManager
    {
        public int Calculate(string traineeName, string traineeGrade, string programmeName, string programmeType, int numberOfMonths, string reportType)
        {
            // This will hold the cost of the programme
            int c;

            switch (programmeType)
            {
                case "Basic":
                    // If the trainee grade is the first year then it will cost 100 per month at Basic level
                    if (traineeGrade == "Year1")
                    {
                        c = numberOfMonths * 200;
                        // generate the report
                        this.GenerateReport(reportType, programmeName, traineeName, c);
                        return c;
                    }
                    // If the trainee grade is the second year then it will cost 250 per month at Basic level
                    else if (traineeGrade == "Year2")
                    {
                        c = numberOfMonths * 250;
                        // generate the report
                        this.GenerateReport(reportType, programmeName, traineeName, c);
                        return c;
                    }
                    break;
                case "Advanced":
                    // If the trainee grade is the first year then it will cost 300 per month
                    if (traineeGrade == "Year1")
                    {
                        c = numberOfMonths * 300;
                        return c;
                    }
                    else if (traineeGrade == "Year2")
                    {
                        // The cost is changing for advanced programmes on 1st Aug 2019, so reflect this in the logic
                        if (DateTime.Now > new DateTime(2019, 8, 1))
                            c = numberOfMonths * 350;
                        else
                            c = numberOfMonths * 400;
                        // generate the report
                        this.GenerateReport(reportType, programmeName, traineeName, c);
                        return c;
                    }
                    break;
                case "Complex":
                    break;
            }

            // If we get here then something has gone wrong so just return a 0 and can handle that as a special case
            return 0;
        }

        private void GenerateReport(string reportType, string traineeName, string programmeName, int cost)
        {
            switch (reportType)
            {
                case "Csv":
                    break;
                case "Pdf":
                    break;
                case "console":
                    string r = traineeName + "in the" + programmeName + "programme will cost" + cost +
                               "pounds per month";
                    Console.WriteLine(r);
                    break;
            }
        }
    }
}
