using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create multi level array
            double[,,] function = new double[21, 41, 3];
            double X;
            double Y;
            double Z;

            //values for the array
            int arrayX;
            int arrayY;

            //start x array index at 0
            arrayX = 0;

            //go through X values
            for (X = -1; X <= 1; X += 0.1)

            {
                //start y array index at 0
                arrayY = 0;

                // go through all y values

                for (Y = 1; Y <= 4; Y += 0.1)

                {
                    //get Z
                    Z = 4 * Y * Y * Y + 2 * X * X - 8 * X + 7;


                    //put the calculated values in the array
                    function[arrayX, arrayY, 0] = X;
                    function[arrayX, arrayY, 1] = Y;
                    function[arrayX, arrayY, 2] = Z;

                    ++arrayY;

                }

                ++arrayX;

            }
        }
    }
}
