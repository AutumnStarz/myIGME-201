using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaV7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create string for user input
            string userInput = null;

            //create char array to hold user input
            char[] reverseArray = null;

            //prompt the user
            Console.WriteLine("Please input a string");
            userInput = Console.ReadLine();

            //convert to a CharArray
            reverseArray = userInput.ToCharArray();

            //reverse it
            Array.Reverse(reverseArray);
            Console.WriteLine(reverseArray);
        }
    }
}
