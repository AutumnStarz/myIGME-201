using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structures
{
    internal class Program
    {
        //static varibles effect the whole struct - static public int enrollement = 1000
        //instance variables effect a specific intance of a struct public double dGrade
        //construtors don't have a return data type
        //get method -> read only
        //set method -> write only
        static void Main(string[] args)
        {
            int[] aInt = new int[23];
            int[] bInt;
            bInt = aInt; //bInt is pointing at the same block of 23 ints in aInt as arrays are reference data types

            object myObject;
            myObject = aInt; //can point at any data type, but is a refrence data type

        }


        public double GivesTest(string subject)
        {
            switch(subject)
            {
                case "math":
                    //math exam
                    break;
            }
            return 100;
        }
    }
}
