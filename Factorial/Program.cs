using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    static internal class Program
    {
        static void Main(string[] args)
        { //a factorial multiplies a postive int by all numbers under it until it reaches 0
            string sNumber = null;
            int nNumber = 0;
            int nAnswer = 0;

            do
            {
                Console.Write("Enter a postive integer: ");
                sNumber = Console.ReadLine();
            } while(!int.TryParse(sNumber, out nNumber) && nNumber <= 0); //stay in the do loop until it parses and is greater than 0

            nAnswer = 1;

            while(nNumber > 0)
            {
                nAnswer *= nNumber;
                --nNumber;
            }

            nAnswer = Factorial(nNumber);

            double a1 = Average(2, 3, 4, 5, 6, 7, 8, 9, 20);
        }

        static double Average(int nRoundTo, params int[] aInt)
        {
            double avg = 0;
            int sum = 0;
            foreach(int i in aInt)
            {
                sum += i;  
            }

            avg = Math.Round((double)sum / aInt.Length, nRoundTo);

            return avg;
        }

        static int Factorial(int nNumber)
        {
            int nAnswer = 1;

            //base case to keep it from factorialing forever until nNumber reaches 0
            if (nNumber == 0)
            {
                nAnswer = 1;
            }
            else //if nNumber isn't 0, factorial it 
            {
                //call itself to get the factorial (recursive function)
                nAnswer = nNumber * Factorial(nNumber - 1); 
            }
            
            return nAnswer;
        }
    }
}
