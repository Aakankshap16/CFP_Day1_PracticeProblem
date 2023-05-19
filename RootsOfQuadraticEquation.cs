using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class RootsOfQuadraticEquation
    {
        public static void call()
        {
            Console.WriteLine("Enter the values of coefficients a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of coefficients b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of coefficients c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Roots are real and different.");
                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("Roots are real and same.");
                Console.WriteLine("Root: " + root);
            }
            else
            {
                Console.WriteLine("Roots are complex and imaginary.");
            }
        }
    }
}
