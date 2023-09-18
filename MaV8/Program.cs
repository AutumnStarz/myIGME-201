using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaV8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string to hold user input
            string userInput = null;
            //prompt the user
            Console.WriteLine("Please enter a string.");
            userInput = Console.ReadLine();
            //set it to lower
            userInput = userInput.ToLower();
            //replace
            userInput = userInput.Replace("no", "yes");
            Console.WriteLine(userInput);
        }
    }
}
