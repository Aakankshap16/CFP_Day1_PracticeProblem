using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class FavouritePlace
    {
        public static void call()
        {
            Console.WriteLine("Please Enter your's favourite place:");
            string place = Console.ReadLine();
         
            Console.WriteLine("Place name in all upper:"+ place.ToUpper());
            Console.WriteLine("Place name 1st in upper remains in lower :"+char.ToUpper(place[0])+ place.Substring(1, place.Length - 1).ToLower());
            Console.WriteLine("Place name in all lower:"+ place.ToLower());
          
        }
    }
}
