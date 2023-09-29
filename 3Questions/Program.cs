using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace _3Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create vars to hold user inputs
            //int QuestionN = 0;
            string userInput = null;
            string userQuestion = null;
            int userQuestionN = 0;
            //string questionA = null;
            string playAgain = null;
            
            //create a reference so we can return to the top
        question:

            //ask the question
            Console.Write("Choose your question (1-3): ");
            userQuestion = Console.ReadLine();

            //try to convert
            try
            {
                userQuestionN = Convert.ToInt32(userQuestion);
            }
            catch
            {
                Console.WriteLine("Please enter a valid number.");
                goto question;
            }

            //check to see what the user input
            if (userQuestionN == 1)
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.WriteLine("What is your favorite color?");
                
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "black") 
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong. The answer is: black");
                }
            }

            else if (userQuestionN == 2)
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.WriteLine("What is the answer to life, the universe and everything?");
                userInput = Console.ReadLine();

                if (userInput == "42")
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong. The answer is: 42");
                }
            }

            else if (userQuestionN == 3)
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                userInput = Console.ReadLine();

                if (userInput == "What do you mean? African or European swallow?")
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Wrong. The answer is: What do you mean? African or European swallow?");
                }
            }
            //exit if they didn't put a valid number
            else 
            {
                Console.WriteLine("That was not one of the options. Goodbye.");
                System.Environment.Exit(1);
            }
            
            play:
            //ask if they want to play again
            Console.WriteLine("Play again?");
            playAgain = Console.ReadLine();

            if (playAgain.ToLower() == "yes")
            {
                goto question;
            }

            else if (playAgain.ToLower() == "no")
            {
                System.Environment.Exit(1);
            }

            else
            {
                goto play;   
            }



        }
    }
}
