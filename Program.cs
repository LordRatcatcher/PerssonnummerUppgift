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
            bool LeapYearCheck = false;
            string GenderCheck = Perssonnummer.Substring(10, 1);
            double GenderCheckNumber = Convert.ToInt32(GenderCheck);
            
          
            

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
            if (LeapYearCheck == true)
            {
                if (DayNumber > 29 && MonthNumber == 02)
                {
                    Console.WriteLine("Något om skottår");
                }
            }
            if (LeapYearCheck == false)
            {
                if (DayNumber > 28 || DayNumber < 1 && MonthNumber == 02)
                {
                    Console.Write("Dåligt Datum");
                }
            }
            if (DayNumber > 31 || DayNumber < 1 && MonthNumber == 03)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 30 || DayNumber < 1 && MonthNumber == 04)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 31 || DayNumber < 1 && MonthNumber == 05)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 30 || DayNumber < 1 && MonthNumber == 06)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 31 || DayNumber < 1 && MonthNumber == 07)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 31 || DayNumber < 1 && MonthNumber == 08) 
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 30 || DayNumber < 1 && MonthNumber == 09)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 31 || DayNumber < 1 && MonthNumber == 10)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 30 || DayNumber < 1 && MonthNumber == 11)
            {
                Console.WriteLine("Dåligt Datum");
            }
            if (DayNumber > 31 || DayNumber < 1 && MonthNumber == 12)
            {
                Console.WriteLine("Dåligt Datum");
            }                        
            Console.WriteLine("Ditt Perssonnummer är acceptabelt!");
            if (GenderCheckNumber == 0 || GenderCheckNumber == 2 || GenderCheckNumber == 4 || GenderCheckNumber == 6 || GenderCheckNumber == 8)
            {
                Console.WriteLine("Ditt Juridiska kön är kvinna");
            }
            if (GenderCheckNumber == 1 || GenderCheckNumber == 3 || GenderCheckNumber == 5 || GenderCheckNumber == 7 || GenderCheckNumber == 9)
            {
                Console.WriteLine("Ditt Juridiska kön är man");
            }   
                Console.ReadKey();
        }
        //Calculating if the year is a leap year and returning a bool true if it is//
        public static bool CalculateLeapYear(double YearNumber, bool LeapYearCheck)
        {


            if (((YearNumber % 4 == 0) && (YearNumber % 100 != 0)) || (YearNumber % 400 == 0))
            {
                Console.WriteLine("Det är ett skottår!");
                LeapYearCheck = true;
                return LeapYearCheck;
                
            }
            else 
            {
                LeapYearCheck = false;
                return LeapYearCheck;

            }


        }
        
    }
}
