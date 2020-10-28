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
            string userinput = "";
            double Perssonnummer = 0;
            userinput = Console.ReadLine();
            Perssonnummer = double.Parse(userinput);
            
            if (Perssonnummer < 175301010101 || Perssonnummer > 202001010101)
            {
                Console.WriteLine("Men Vafan då detta är ju inte möjligt");
                
            }

            Console.ReadKey();
        
        }
        
        
    }
}
