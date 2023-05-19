using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class CheckPresence
    {
        public static void call()
        {
            Console.WriteLine("Enter your string:");
            string name = Console.ReadLine();
            bool isAPresent = false;
            bool isEPresent = false;
            bool isPPresent = false;

            foreach (char c in name)
            {
                if (c == 'a')
                {
                    isAPresent = true;
                }
                else if (c == 'e')
                {
                    isEPresent = true;
                }
                else if (c == 'p')
                {
                    isPPresent = true;
                }
            }

            if (isAPresent && isEPresent && isPPresent)
            {
                Console.WriteLine("All Present");
            }
            else if (isAPresent || isEPresent || isPPresent)
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        
        }
    }
}
