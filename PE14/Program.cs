using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    internal class Program
    {

        //# 1 on PE14 - classy
        public abstract class BaseClass
        {
            //create a private feild
            private string pField;

            //create a red-write property
            public string Field 
            { 
                get
                { 
                    return pField; 
                } 
                set 
                { 
                    pField = value;
                } 
            }
        }

        //#2 on classy

        //create interface
        public interface iClassy
        {
            void iMethod();
        }

        //create class1 to inherit from interface
        public class oneClassy : iClassy
        {
            public void iMethod()
            {
                Console.WriteLine("This is from oneClassy");
            }
        }

        //create 2nd class to inherit from interface
        public class twoClassy : iClassy
        {
            public void iMethod() 
            {
                Console.WriteLine("This is from twoClassy");
            }
        }

        static void Main(string[] args)
        {
            oneClassy classy = new oneClassy();
            twoClassy classy2 = new twoClassy();

            MyMethod(classy);
            MyMethod(classy2);
        }

        //method that calls the interface
        public static void MyMethod(iClassy classy)
        {
            classy.iMethod();
        }
    }
}
