using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class PerimeterAndAreaOfCircle
    {
        public static void call()
        {
            double parameter, area;
            Console.WriteLine("Enter the diameter of Circle:");
            int d = Convert.ToInt32(Console.ReadLine());
            parameter = (2 * (Math.PI) * d/2);
            area = (Math.PI) * d / 2 * d / 2;
            Console.WriteLine("Parameter of the circle is :"+ parameter);
            Console.WriteLine("Area of the circle is :"+ area);


        }
    }
}
