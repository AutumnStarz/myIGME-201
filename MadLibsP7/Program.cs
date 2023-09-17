using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            int numLibs = 0;
            int cntr = 0;
            int nChoice = 0;
            string sChoice = null;
            string userName = null;

            string finalStory = "";
            string resultString = null;
            string userResponse = null;



            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt"); //how to pass your code a file to read

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();

            //ask the user for their name
            Console.WriteLine("Welcome! Please enter your name!");
            userName = Console.ReadLine();

            ask:
            //ask them if they want to play
            Console.WriteLine("Do you want to play Mad Libs?");
            userResponse = Console.ReadLine();
            if (userResponse.ToLower() == "yes")
            {

            }

            else if (userResponse.ToLower() == "no")
            { //end program if they say no
                Console.WriteLine("Goodbye then!");
                System.Environment.Exit(1);
            }
            else
            { //send them back to the question if they say anything else
                Console.WriteLine("Please enter 'yes' or 'no'.");
                goto ask;
            }

            // prompt the user for which Mad Lib they want to play (nChoice)
            Console.WriteLine("Which story do you want to play?(0-5)");
            sChoice = Console.ReadLine();

            //try to convert nChoice to int
            try
            {
                nChoice = Convert.ToInt32(sChoice);
            }
            catch //send them back to the beginning if they don't
            {
                Console.WriteLine("Please enter a number 0 - 5");
                goto start;
            }
            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice].Split(' ');

            foreach (string word in words)
            {
                // if word is a placeholder
                if (word[0] == '{')
                {
                    string replaceWord = word.Replace("{", " ").Replace("}", " ").Replace("_", " ");
                    // prompt the user for the replacement
                    Console.Write("Input a {0}: ", replaceWord);
                    // and append the user response to the result string
                    finalStory += Console.ReadLine();
                }
                // else append word to the result string
                else
                {
                    finalStory += word;
                }
                

                resultString = finalStory;

                
            }
            Console.WriteLine(resultString);
        }
    }
}
