using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class FindAverage
    {
        public static void call()
        {
            int sum = 0;
            double avg;
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int num = random.Next(10, 50);
                Console.Write(num + " ");
                sum += num;
                
            }
            avg = sum / 5;
            Console.WriteLine();
            Console.WriteLine("Avg of 5 random no is : "+ avg); 
        }
    }
}
