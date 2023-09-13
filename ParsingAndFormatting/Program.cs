using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingAndFormatting
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            //introduction
            Console.WriteLine("Welcome to the guessing game! Your task is to guess a randomized number between 0-100!");

            //create a new random
            Random random = new Random();
            //hold that random in an int
            int randomNumber = random.Next(0, 101);

            //create two vars to hold user guesses
            string sAnswer = null;
            int nAnswer = 0;

            //create an int for the for loop that will keep track of how many guesses theyve used
            int i = 0;

            //Console.WriteLine(randomNumber); //< test line

            //create for loop that gives the user 8 chances to guess starting at 1
            for (i = 1; i <= 8; i++)
            {
                //prompt the user
                Console.Write("Guess #");
                Console.WriteLine(i);
                sAnswer = Console.ReadLine();

                //make sure the answer is vaild (not a string) and attempt to convert
                try
                {
                    nAnswer = Convert.ToInt32(sAnswer);
                }
                catch
                {
                    Console.WriteLine("Please enter NUMBERS!");
                    sAnswer = Console.ReadLine();

                    try
                    {
                        nAnswer = Convert.ToInt32(sAnswer);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter NUMBERS!");
                        sAnswer = Console.ReadLine();


                    }

                }

                //make sure the number is actually within the randomizers range and if not, make the user sit in a loop until they enter a valid number
                while (nAnswer < 0 || nAnswer > 100)
                {
                    Console.WriteLine("Please enter a valid number");
                    sAnswer = Console.ReadLine();
                    try
                    {
                        nAnswer = Convert.ToInt32(sAnswer);
                    }
                    catch
                    {
                        Console.WriteLine("Please enter NUMBERS!");
                    }
                }

                //give the user feedback based on whether the number was too high, too low, or correct
                if (nAnswer == randomNumber)
                {
                    Console.WriteLine("Correct!");
                    Console.Write("It took you ");
                    Console.Write(i);
                    Console.WriteLine(" guess(es) to get it correct!");
                    break; //end the loop when the get it right
                }

                else if (nAnswer > randomNumber)
                {
                    Console.WriteLine("Too high!");
                }

                else if (nAnswer < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }



            }

            //tell them when theyre out of guess and what the correct number was
            if (i == 9)
            {
                Console.WriteLine("You're out of guesses! The correct number was:");
                Console.WriteLine(randomNumber);
            }





        }
    }
}
