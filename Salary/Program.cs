using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create vars to hold values
            string sName;
            double dSalary = 30000;
            bool raise;

            //prompt the user tp enter their name
            Console.Write("Hello! Please enter your name: ");
            sName = Console.ReadLine();

            raise = GiveRaise(sName,ref dSalary);

            //check whether or not it returned true
            if( raise == true )
            {
                Console.WriteLine("Congrats on the raise! Your new salary is $49,999.99");
            }
            else
            {
                Console.WriteLine(sName + ", your current salary is $30,000.");
            }


        }
        static bool GiveRaise(string name, ref double salary)
        { //check if the name == my name
            if (name.ToLower() == "autumn")
            {
                salary += 19999.99;
                return true;
            }
            //return false if no
            else 
            {
                return false;
            }
        }
    }
}
