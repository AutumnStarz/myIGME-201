using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FE1
{
    internal class Program
    {
        //stack class #1 (queue class below)
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

            //queue class #2
            public class MyQueue
            {
                //the queue
                private List<int> Queue = new List<int>();

                //enqueue
                public void Enqueue(int obj)
                {
                    Queue.Add(obj);
                }
                //dequeue
                public int Dequeue()
                {
                    int dequeued = Queue[0];
                    Queue.RemoveAt(0);
                    return dequeued;
                }
                //peek
                public int Peek()
                {
                    return Queue[0];
                }
            }
            static void Main(string[] args)
            {

            }
        }
    }
}
