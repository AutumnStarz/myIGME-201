using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 needs a semicolon (syntax error)
            int i = 0;

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) ++i needs to be i++ (syntax error)
            for (i = 1; i <= 10; i++)
            {
                // declare string to hold all numbers
                string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); + can't be used to combined ints and strings (
                Console.Write(i);
                Console.Write(" / ");
                Console.Write(i);
                Console.Write(" - 1");
                Console.Write(" = ");

                // output the calculation based on the numbers
                if (i > 1)
                { //to keep it from dividing by 0, (run time error)
                    Console.Write(i / (i - 1));
                    Console.WriteLine(" "); //added to space things out
                }

                else
                {
                    Console.WriteLine(0); //for the first output
                }

                // concatenate each number to allNumbers
                allNumbers += i.ToString() + " ";

                // increment the counter
                //i = i + 1; there is already a counter in the for loop

                Console.WriteLine("These numbers have been processed: ", allNumbers);
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); //moved into the loop so it can access allNumbers, also added a comma (syntax error)
        }
    }
}

