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
            Perssonnummer = Console.ReadLine();            
            string År = Perssonnummer.Substring(0, 4);
            double ÅrNummer = Convert.ToInt32(År);
            if (ÅrNummer < 1753)
            {
                Console.WriteLine("För litet nummer!");
            }

            Console.ReadKey();
        }
        
        
    }
}
