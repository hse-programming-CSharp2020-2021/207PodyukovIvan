using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Linked List");
            LinkedList<int> linkedList = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            while (x > 0)
            {
                linkedList.AddFirst(x % 10);
                stack.Push(x % 10);
                x = x / 10;
            }
            foreach (int i in linkedList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Stack");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }
        }
    }
}
