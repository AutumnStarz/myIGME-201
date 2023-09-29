using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic list data type (only index based on number)
            List<double> list = new List<double>(); //creation of a list data type
            List<double> list2 = new List<double>();
            list.Add(1); //add an element to a list
            list = list2.GetRange(0, list2.Count); //copy list2 into list
            list.Sort();//sort in decending order
            list.Reverse();//sort in acending order

            //dictionary
            Dictionary<string, int> dPersonAge = new Dictionary<string, int>(); //a list type that allows you to sort by keys
            //Dictionary<string, StudentStruct> dStudent = new Dictionary<string, StudentStruct> (you can store any data type, even structs or delegates)

            dPersonAge.Add("Sue", 84);
            dPersonAge["david"] = 50; //add an index to the dictionary
            

            //cannot add the same key twice
            // dPersonAge.Add("david", 60)

            //however it can be updated
            dPersonAge["david"] = 60;

            foreach(KeyValuePair<string, int> valuePair in dPersonAge)
            {
                Console.WriteLine($"person[{valuePair.Key}] = {valuePair.Value}"); //key = name  age = value
            }
            //dictionary doesn't auto sort but Sorted List does
            SortedList<string, int> personAge = new SortedList<string, int>();
            personAge.Add("Sue", 84);
            personAge["david"] = 50;
            personAge["joe"] = 80;

            personAge.Remove("joe"); //remove an element

            //go through each element the same way as dictionary
            foreach (KeyValuePair<string, int> valuePair in personAge)
            {
                Console.WriteLine($"person[{valuePair.Key}] = {valuePair.Value}"); //key = name  age = value
            }
        }
    }
}
