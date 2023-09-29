using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function 
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY needs a ; compile time
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); needs " " - compile-time

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); needs to be read out into sNumber - logical error
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } while (int.TryParse(sNumber, out nY)); //while (int.TryParse(sNumber, out nX)); out needs to be nY, not nX

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


        static int Power(int nBase, int nExponent) //needs to have a static in front - logic
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; needs to actually return something - logic error

            return returnVal;
        }
    }
}
