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
            string perssonNummer = "";
            yearCalculator.CalculateLeapYear();
            //create string Perssonnummer//                        
            perssonNummer = Console.ReadLine();
            //Declare the index numbers of Perssonnumber for each use//
            string Year = perssonNummer.Substring(0, 4);
            double yearNumber = Convert.ToInt32(Year);
            string Month = perssonNummer.Substring(4, 2);
            double monthNumber = Convert.ToInt32(Month);
            string Day = perssonNummer.Substring(6, 2);
            double DayNumber = Convert.ToInt32(Day);
            string LastPart = perssonNummer.Substring(8, 4);
            double LastPartNumbers = Convert.ToInt32(LastPart);
            bool leapYearCheck = false;
            string genderCheck = perssonNummer.Substring(10, 1);
            double genderCheckNumber = Convert.ToInt32(genderCheck);
            int validNumber = 1;



            //If statements to check for incorrect inputs//
            if (yearNumber < 1753 || yearNumber > 2020)
            {
                Console.WriteLine("Inte giltigt år");
                validNumber = 0;
            }
            if (monthNumber > 12 || monthNumber <= 0)
            {
                Console.WriteLine("Inte giltig månad");
                validNumber = 0;
            }
            if (DayNumber > 31 && monthNumber == 01)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            //If statement that only activates if it is a leap year//
            if (leapYearCheck == true)
            {
                if (DayNumber > 29 && monthNumber == 02)
                {
                    Console.WriteLine("Inte giltigt datum");
                    validNumber = 0;
                }
            }
            if (leapYearCheck == false)
            {
                if (DayNumber > 28 || DayNumber < 1 && monthNumber == 02)
                {
                    Console.Write("Inte giltigt datum");
                    validNumber = 0;

                }
            }
            if (DayNumber > 31 || DayNumber < 1 && monthNumber == 03)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 30 || DayNumber < 1 && monthNumber == 04)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 31 || DayNumber < 1 && monthNumber == 05)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 30 || DayNumber < 1 && monthNumber == 06)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 31 || DayNumber < 1 && monthNumber == 07)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 31 || DayNumber < 1 && monthNumber == 08) 
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 30 || DayNumber < 1 && monthNumber == 09)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 31 || DayNumber < 1 && monthNumber == 10)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 30 || DayNumber < 1 && monthNumber == 11)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (DayNumber > 31 || DayNumber < 1 && monthNumber == 12)
            {
                Console.WriteLine("Inte giltigt datum");
                validNumber = 0;
            }
            if (LastPartNumbers > 9999 || LastPartNumbers < 0001)
            {
                Console.WriteLine("Dina sista 4 siffror är inte giltiga");
                validNumber = 0;
            }
            if (validNumber == 1)
            {
                Console.WriteLine("Ditt Perssonnummer är acceptabelt!");
            }
            else if (validNumber == 0)
            {
                Console.WriteLine("Ditt personnummer är inte acceptabelt");
            }
            //Checking if it is a man or a woman//           
            if (genderCheckNumber == 0 || genderCheckNumber == 2 || genderCheckNumber == 4 || genderCheckNumber == 6 || genderCheckNumber == 8)
            {
                Console.WriteLine("Ditt Juridiska kön är kvinna");
            }
            if (genderCheckNumber == 1 || genderCheckNumber == 3 || genderCheckNumber == 5 || genderCheckNumber == 7 || genderCheckNumber == 9)
            {
               //printing out the needed information//
                Console.WriteLine("Ditt Juridiska kön är man");
            }   
            
            Console.ReadKey();
        }
        public class yearCalculator
        { 
        //Calculating if the year is a leap year and returning a 1 if it is true//
         public static double CalculateLeapYear()
         {
                //having to type it in twice, need help with this//
                string Perssonnummer = "";
                Perssonnummer = Console.ReadLine();
                string Year = Perssonnummer.Substring(0, 4);
                double yearNumber = Convert.ToInt32(Year);
                Console.WriteLine("Skriv in ditt personnummer igen!");
                int leapYearCheck = 0;
                if (((yearNumber % 4 == 0) && (yearNumber % 100 != 0)) || (yearNumber % 400 == 0))
            {
                    
                
                    leapYearCheck = 1;
                return leapYearCheck;
                
            }
            else 
            {
                    leapYearCheck = 0;
                return leapYearCheck;

            }


         }
        }
    }
}
