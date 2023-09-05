using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment Variables and Expression - Question 5
//Create a program that prompts the user for 4 numbers and returns the product

namespace VarsAndExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create 4 vars to hold user responses as strings and 4 to hold the converted ints and one to hold the product
            int var1 = 0;
            int var2 = 0;
            int var3 = 0;
            int var4 = 0;
            string sVar1 = null;
            string sVar2 = null;
            string sVar3 = null;
            string sVar4 = null;
            int product = 0;


            //prompt the user for 4 numbers
            //read what the user typed and store it in a variable (4 times)

            Console.WriteLine("Hello, after each prompt, please enter a number.");

            Console.Write("Enter your first number:");
            sVar1 = Console.ReadLine();

            Console.Write("Enter your second number:");
            sVar2 = Console.ReadLine();

            Console.Write("Enter your third number:");
            sVar3 = Console.ReadLine();

            Console.Write("Enter your fourth number:");
            sVar4 = Console.ReadLine();


            //convert string vars to ints so they can be used in a caluclation
            try { 
            var1 = Convert.ToInt32(sVar1);
            var2 = Convert.ToInt32(sVar2);
            var3 = Convert.ToInt32(sVar3);
            var4 = Convert.ToInt32(sVar4);
            }
            catch {

                Console.WriteLine("Please enter numbers!");
            }

            //perform the calculations and store it in the product variable
            product = (var1 * var2 * var3 * var4);


            //display the product variable
            Console.Write("And your product is: ");
            Console.WriteLine(product);
        }
    }
}
