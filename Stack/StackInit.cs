using System;

namespace Stack
{
    class StackInit
    {
        static void Main(string[] args)
        {
            CustomStack<int> intStack = new CustomStack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine(intStack.Size()); //size is 3
            intStack.Pop();
            Console.WriteLine(intStack.Peek());
            Console.WriteLine(intStack.Size()); //size is 2 as we are only peeking
        }
    }
}
