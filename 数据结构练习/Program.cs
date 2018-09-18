using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            Console.WriteLine("15");
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);
            myStack.Push(9);
            myStack.Push(10);
            myStack.Push(11);
            myStack.Push(12);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(10);
            myStack.Push(999);
            while (myStack.IsEmpty()!=true)
            {
                Console.WriteLine(myStack.Pop()+" Count: "+ myStack.Count);
            }
            Console.ReadKey();
        }
    }
}
