using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaV9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create variable to hold the final result
            string result = null;
            //create variable for user input
            string userInput = null;
            //prompt user for string
            Console.WriteLine("Please enter a string.");
            userInput = Console.ReadLine();

            //store user input into an array and split up the words
            string[] inputArray = userInput.Split(' ');

            //for each element in the array, put double quotes
             for (int i = 0; i < inputArray.Length; i++) //could of also used a for each here
            {
                //stick double quotes on
                inputArray[i] = "\"" + inputArray[i] + "\"";
            }

             //hold the final result in "result" variable by joining the array into a string
             result = string.Join(" ", inputArray);

            //print the result
            Console.WriteLine(result);
        }
    }
}
