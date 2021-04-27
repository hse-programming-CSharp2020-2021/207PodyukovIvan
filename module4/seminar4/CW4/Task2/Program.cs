using System;
using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    class Evens : IEnumerable
    {
        private int a;
        private int b;
        List<int> list = new List<int>();
        public Evens(int a, int b)
        {
            this.a = a;
            this.b = b;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(i);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
    class Program
    {
        static void Main()
        {
            Evens ev = new Evens(20, 43);
            foreach (var t in ev)
                Console.Write(t + "  ");
            Console.WriteLine();
            Console.ReadKey();
        } 
    }
}
