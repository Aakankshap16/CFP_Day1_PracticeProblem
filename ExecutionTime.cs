using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class ExecutionTime
    {
        public static void call()
        {
       
            var watch = Stopwatch.StartNew();
            watch.Start();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }
            watch.Stop();
            Console.WriteLine("Execution Time:" + watch.ElapsedMilliseconds);
        }
    }
}
