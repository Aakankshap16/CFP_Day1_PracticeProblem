using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class PrintWithOutUsingLoop
    {
        public static void call(int num)
        {
            
            if (num <= 100)
            {
                Console.WriteLine(num);
                call(num + 1);
            }
        }
    }
}
