using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
