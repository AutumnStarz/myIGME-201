using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            { 
            int[] myIntArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //starts at 0
            //myIntArray[0]
            int[] myIntArray2 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 }; //create an array of 8 values
            }
            int[] myIntArray3 = new int[8];
            myIntArray3[0] = 5; //add a new value to the zero spot in myIntArray
            myIntArray3[1] = 6;
            myIntArray3[2] = 7;
            myIntArray3[3] = 8;
            myIntArray3[4] = 9;
            myIntArray3[5] = 10;
           

            int[] myIntArray4;
            myIntArray4 = myIntArray3; //functions like a mirror as arrays are reference based

            myIntArray4[0] = 10; //now 0 is 10 in both myIntArray3 and myIntArray4

            myIntArray3 = null; //basically abandoning your array
            myIntArray4 = null;

            { //enclose code in brackets to isolate it from your other code
                int arraySize = 5;
                int[] myIntArray = new int[arraySize];
            }

            int[,] functVal = new int[21, 2]; //how to make 2D array
            int x = 0;
            int y = 0;
            int xCnter = 0;
            for (x = -10; x <= 10; x++, ++xCnter)
            {
               //i gave up copying here
            }

            {

                int[][] jaggedIntArray = new int[3][]; //jagged array [define this element][]
                jaggedIntArray[0] = new int[3]; //could hold 3 values
                jaggedIntArray[1] = new int[4]; //could hold 4 values

                //first dimension can hold 3
                jaggedIntArray[0][0] = 1;
                jaggedIntArray[0][1] = 2;
                jaggedIntArray[0][2] = 3;
                //second dimenesion can hold 4
                jaggedIntArray[1][0] = 4;
                jaggedIntArray[1][1] = 5;
                jaggedIntArray[1][2] = 6;
                jaggedIntArray[1][3] = 7;
            }


        
        } 
      

    }
}
