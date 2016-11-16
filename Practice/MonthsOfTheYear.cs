using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthsOfTheYear
{
    class Program
    {

        public enum Month {January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a month number between 1 and 12:");

            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput > 12 || userInput < 1)
            {
                Console.WriteLine("Please enter a month number between 1 and 12:");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            Month month = (Month)userInput;
            Console.WriteLine(month);

            Console.ReadKey();
        }
    }
}
