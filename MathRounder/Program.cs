using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathRounder
{
    internal class Program
    {
        delegate double RoundDelegate(double value);
        static void Main(string[] args)
        {
            Start:

            string userInputS = null;
            double userInputD = 0;
            RoundDelegate roundDelegate = Round;
            Console.WriteLine("Please enter a double to round up.");
            userInputS = Console.ReadLine();
            try
            {
                userInputD = Convert.ToDouble(userInputS);

            }
            catch
            {
                Console.WriteLine("Please enter double to round");
                goto Start;

            }
            Console.WriteLine(roundDelegate(userInputD));

        }

        static double Round(double value)
        {
            double rounded = Math.Ceiling(value);

            return rounded;
        }
    }
}
