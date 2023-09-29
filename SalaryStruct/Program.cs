using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SalaryStruct
{
    internal class Program
    {
        //create employee struct
        struct Employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {
            bool raise = false;
            string sName;
            //create a new employee
            Employee e = new Employee();

            Console.Write("Hello! Please enter your name: ");
            sName = Console.ReadLine();
            e.sName = sName;
            //put the struct values into the function
            raise = GiveRaise(e.sName,ref e.dSalary);

            if (raise == true)
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
