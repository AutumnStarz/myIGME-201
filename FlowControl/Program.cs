using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create int vars
            int var1 = 0;
            int var2 = 0;

            //prompt the user for two numbers and store them in string vars
            Console.WriteLine("Please enter a number!");
            string sA = Console.ReadLine();
            Console.WriteLine("Please enter another number!");
            string sB = Console.ReadLine();

            //try to make sure the user actually entered numbers
            try
            {
                 var1 = Convert.ToInt32(sA);
                 var2 = Convert.ToInt32(sB);

            }
            catch
            { //and catch it if they didnt
                Console.WriteLine("Please enter numbers!");
            }

            //check if both are greater than 10
            if (var1 > 10 && var2 > 10)
            {
                Console.WriteLine("Please enter 2 number less than or equal to 10!");
            }


        }
    }
}
