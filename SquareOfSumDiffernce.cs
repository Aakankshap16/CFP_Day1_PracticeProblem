using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
   public class SquareOfSumDiffernce
    {
        public static void call()
        {
            Console.WriteLine("Enter 1st number:");
            double n1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2st number:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double Sum, Sub;
            double sqSum, sqSub;

            Sum = n1 +  n2; 
            Sub = n1 - n2;  

            sqSum = Math.Pow(Sum, 2);
            sqSub = Math.Pow(Sub, 2);

            Console.WriteLine("Square of the sum of 2 no. is: " + sqSum);
            Console.WriteLine("Square of the diff of 2 no. is: "+  sqSub);



        }
    }
}
