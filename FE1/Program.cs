using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE1
{
    internal class Program
    {
        //stack class
        public class MyStack
        {
            //create the stack item
            public List<int> Stack = new List<int>();
            public MyStack() 
            {

            }
            //push
            public void Push(int x) 
            { 
                Stack.Add(x);
            }
            //pop
            public int Pop()
            {
                int lastVal = Stack.Count - 1;
                int popped = Stack[lastVal];
                Stack.RemoveAt(lastVal);
                return popped;
            }
            //peek
            public int Peek() 
            {
                return Stack[Stack.Count - 1];
            }
        static void Main(string[] args)
        {

        }
    }
}
