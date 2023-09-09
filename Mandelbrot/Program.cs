using System;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            double endImagCoord, endRealCoord; //doubles to catch the new end values
            double tRealCoord, tImagCoord;
            string sImagCoord = null; //strings to catch user responses
            string sRealCoord = null;
            string eImagCoord = null;
            string eRealCoord = null;

            //prompt the user for start and end values
            Console.WriteLine("Please enter a start value for imagCoord i.e 1.2");
            sImagCoord = Console.ReadLine();
            Console.WriteLine("Please enter a start value for realCoord i.e -0.6");
            sRealCoord = Console.ReadLine();
            Console.WriteLine("Please enter a end value for imagCoord i.e -1.2");
            eImagCoord = Console.ReadLine();
            Console.WriteLine("Please enter a end value for realCoord i.e 1.77");
            eRealCoord = Console.ReadLine();

            //try catch to make sure the user is entering the correct thing (not a string)
            try
            {
                //convert the strings to doubles
                endImagCoord = Convert.ToDouble(eImagCoord);
                endRealCoord = Convert.ToDouble(eRealCoord);
                imagCoord = Convert.ToDouble(sImagCoord);
                realCoord = Convert.ToDouble(sRealCoord);
                //make sure the values are valid
                if (imagCoord <= endImagCoord && realCoord >= endRealCoord)
                {
                    Console.WriteLine("Please enter a value for imagCoord greater than its end value and a value less than realCoords end value!");
                }
            }
            catch
            {
                //make sure the values are vid
                Console.WriteLine("Please enter valid values!");

            }
            //convert these outside of the try catch
            endImagCoord = Convert.ToDouble(eImagCoord);
            endRealCoord = Convert.ToDouble(eRealCoord);

            for (imagCoord = Convert.ToDouble(sImagCoord); imagCoord >= endImagCoord; imagCoord -= 0.05)
            {
                for (realCoord = Convert.ToDouble(sRealCoord); realCoord <= endRealCoord; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}