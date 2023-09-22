using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions3
{
    static class Program
    {  
        
        //create the delegate
        delegate string ReadLine();

        static void Main(string[] args)
        {
            //create the delegate var and give it the fake input from the method
            ReadLine readlineDelegate = MockUserInput;

            //store it in a userInput var
            string userInput = readlineDelegate();

            //print the fake input to the console
            Console.WriteLine(userInput);

        }

        //create a method to simulate user input
        static string MockUserInput()
        {
            //return a test value
            return "Test user input";
        }
    }
}
