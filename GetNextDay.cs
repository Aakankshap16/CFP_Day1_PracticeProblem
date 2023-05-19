using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class GetNextDay
    {
        public static void call()
        {
            Console.Write("Input a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a month [1-12]: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a day [1-31]: ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Calculate the next day
            DateTime currentDate = new DateTime(year, month, day);
            DateTime nextDate = currentDate.AddDays(1);

            // Format and display the next date
            string nextDateFormatted = nextDate.ToString("yyyy-M-d");
            Console.WriteLine("The next date is [yyyy-mm-dd]: " + nextDateFormatted);
        }
    }
}
