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
            YearCalculator.CalculateLeapYear();
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
            //If statement that only activates if it is a leap year//
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
            if (LastPartNumbers > 999 || LastPartNumbers < 001)
            {
                Console.WriteLine("Men vafan då");
            }
            //Checking if it is a man or a woman//
            Console.WriteLine("Ditt Perssonnummer är acceptabelt!");
            if (GenderCheckNumber == 0 || GenderCheckNumber == 2 || GenderCheckNumber == 4 || GenderCheckNumber == 6 || GenderCheckNumber == 8)
            {
                Console.WriteLine("Ditt Juridiska kön är kvinna");
            }
            if (GenderCheckNumber == 1 || GenderCheckNumber == 3 || GenderCheckNumber == 5 || GenderCheckNumber == 7 || GenderCheckNumber == 9)
            {
               //printing out the needed information//
                Console.WriteLine("Ditt Juridiska kön är man");
            }   
            
            Console.ReadKey();
        }
        public class YearCalculator
        { 
        //Calculating if the year is a leap year and returning a 1 if it is true//
         public static double CalculateLeapYear()
         {
                //having to type it in twice, need help with this//
                string Perssonnummer = "";
                Perssonnummer = Console.ReadLine();
                string Year = Perssonnummer.Substring(0, 4);
                double YearNumber = Convert.ToInt32(Year);
                Console.WriteLine("Skriv in ditt personnummer igen!");
                int LeapYearCheck = 0;
                if (((YearNumber % 4 == 0) && (YearNumber % 100 != 0)) || (YearNumber % 400 == 0))
            {
                    
                
                    LeapYearCheck = 1;
                return LeapYearCheck;
                
            }
            else 
            {
                    LeapYearCheck = 0;
                return LeapYearCheck;

            }


         }
        }
    }
}
