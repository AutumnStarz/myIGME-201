using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //delegate method is a data type
            //data type we create ourselves 
            //1.defind the data type based on the methods signeture
               //delegate double MathFunction(double n1, double n2);
            //2. declare the delegate method variable
               //MathFunction processDivMult;
            //3. point to the method we want to call
               //processDivMult = new MathFunction(Multiply);
            //4. call the method
               //nAnswer = processDivMult(n1, n2)

            //Func<double, double, double>processDivMult <-- generic data type, returns a value
            //Action<> <--- does not return a value

            //anyonomus code block
            //processDivMult = delegate(double n1, double n2) //create a method with no name
              //{
              //double returnVal = 0
              //Return Val = n1 * n2
              //}

            //lamda function => 
            //processDivMult = (n1,n2) =>
            //{ }
        }
    }
}
