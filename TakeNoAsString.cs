using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class TakeNoAsString
    {
        public static void call()
        {
            Console.WriteLine("Enter your NUmber:");
            string number = Console.ReadLine();
            int newNum = int.Parse(number)*10;


            Console.WriteLine($" 10 time of the number is:{newNum.ToString()}");
        }
    }
}
