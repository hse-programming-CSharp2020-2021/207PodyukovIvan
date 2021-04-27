using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class TriangleNums
    {
        internal IEnumerable<int> nextMemb(int v)
        {
            for (int i = 0; i < v; i++)
            {
                yield return i * (i + 1) / 2;
            }
        }
    }
    class Fibbonacci
    {
        int current = 1;
        int previous = 0;

        internal IEnumerable<int> nextMemb(int v)
        {
            current = 1;
            previous = 0;
            for (int i = 0; i < v; i++)
            {
                int temp = current;
                current = current + previous;
                previous = temp;
                yield return current;
            }
        }
    }

    class Program
    {
        static void Main()
        {

            Fibbonacci fi = new Fibbonacci();
            TriangleNums tr = new TriangleNums();
            List<int> fib = new List<int>();
            List<int> tri = new List<int>();
            foreach (int numb in fi.nextMemb(7))
            {
                fib.Add(numb);
                Console.Write(numb + "  ");
            }
            Console.WriteLine();
            foreach (int numb in tr.nextMemb(7))
            {
                tri.Add(numb);
                Console.Write(numb + "  ");
            }
            Console.WriteLine();
            for (int i = 0; i < fib.Count; i++)
            {
                Console.Write(fib[i] + tri[i] + "  ");
            }
            Console.WriteLine();
        }
    } 
}
