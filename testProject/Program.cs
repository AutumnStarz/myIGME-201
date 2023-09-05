using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 4;
            int num3 = 5;

            

            num1 = num1 * num3;
            num2 = num1 / num2;
            num3 = num3 % num2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.Write("Hi there");
            Console.Write("David");

            Console.Out.WriteLine("50 plus 25 is " + 50 + 25);

            string eNo = "No";
            string sNo = "No";

            if (eNo == sNo)
            {
                Console.WriteLine("equal!");
            }
        }
    }
}
