using System;

namespace PerssonnummerCheckare
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****************************");
            Console.WriteLine("*Skriv in ditt perssonnummer*");
            Console.WriteLine("*****************************");
            string Perssonnummer = "";
            //create string Perssonnummer//                        
            Perssonnummer = Console.ReadLine();
            //Declare the index numbers of Perssonnumber for each use//
            string Year = Perssonnummer.Substring(0, 4);
            double YearNumber = Convert.ToInt32(Year);
            string Month = Perssonnummer.Substring(4, 2);
            double MonthNumber = Convert.ToInt32(Month);
            string Day = Perssonnummer.Substring(6, 2);
            double DayNumber = Convert.ToInt32(Day);
            string LastPart = Perssonnummer.Substring(8, 4);
            double LastPartNumbers = Convert.ToInt32(LastPart);            
            int LeapYearCheck = 0;
            CalculateLeapYear(LeapYearCheck);


            //If statements to check for incorrect inputs//
            if (YearNumber < 1753 || YearNumber > 2020)
            {
                Console.WriteLine("För litet nummer!");
            }
            if (MonthNumber > 12 || MonthNumber <= 0)
            {
                Console.WriteLine("inte giltig månad");
            }
            if (DayNumber > 31 && MonthNumber == 01)
            {
                Console.WriteLine("För sent datum");
            }
            if (LeapYearCheck == 1)
            {
                if (DayNumber > 29 && MonthNumber == 02)
                {
                    Console.WriteLine("Något om skottår");
                }
            }
            
            Console.ReadKey();
        }
        //Calculating if the year is a leap year and returning a bool//
        static public void CalculateLeapYear(double YearNumber)
        {
            
            double YearCalculation = YearNumber;
            if (((YearNumber % 4 == 0) && (YearNumber % 100 != 0)) || (YearNumber % 400 == 0))
            {
               int LeapYearCheck = 1;
                
                
            }
        }
        
    }
}
