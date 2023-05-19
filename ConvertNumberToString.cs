using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class ConvertNumberToString
    {
        public static string call(int number)
        {
            string result = "";

            if (number % 3 == 0)
                result += "Pling";

            if (number % 5 == 0)
                result += "Plang";

            if (number % 7 == 0)
                result += "Plong";

            if (string.IsNullOrEmpty(result))
                result = number.ToString();

            return result;
        }
    }
}
