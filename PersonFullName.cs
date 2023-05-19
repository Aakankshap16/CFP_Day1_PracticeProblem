using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_PracticeProblem
{
    public class PersonFullName
    {
        public static void call()
        {
            Console.WriteLine("Enter Your FullName (FirstName MiddleName LastName):");
            string name = Console.ReadLine();
            string[] arr= name.Split(" ");
           
            Console.WriteLine("No. of parts of Name : " + arr.Length);  
            foreach (string s in arr) 
            {
                
                Console.Write(s + " ");
            }
           


        }
    }
}
