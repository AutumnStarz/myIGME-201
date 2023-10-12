using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassMems
{
    internal class Program
    {
       public class MyClass
        {
            private string myString;
            public virtual string GetString()
            {
                return myString;
            }

            public string MyString
            {
                set
                {
                    myString = value;
                }
            }
        }
        public class MyDerivedClass : MyClass
        {
            public override string GetString()
            {
                return base.GetString() + " output from the derived class";
            }

        }

        static void Main(string[] args)
        {
            new MyDerivedClass().GetString();
        }
    }
}
