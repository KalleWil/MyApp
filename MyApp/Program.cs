using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            var year = Convert.ToInt32(Console.ReadLine());

            Program program = new Program();
            if(program.IsLeapYear(year)){
                Console.WriteLine("yay");
            }
            else
            {
                Console.WriteLine("nay");
            }
            

        }

        public bool IsLeapYear(int year){
            if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            } 
            return false;
        }
    }
}
