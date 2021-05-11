using System;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rand.Next(-1000, 1001));
            }
            Console.WriteLine("Исходная коллекция:");
            foreach (var t in list)
            {
                Console.Write(t+" ");
            }
            Console.WriteLine();
            var linq1 = from t in list
                        select t * t;
            var linq2 = list.Where(t => t > 9 && t < 100);
            var linq3 = from t in list
                        where t % 2 == 0
                        orderby t descending
                        select t;
            var linq4 = list.GroupBy(t => Math.Abs(t).ToString().Length);
            Console.WriteLine("Linq1:");
            foreach (var t in linq1)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Linq2:");
            foreach (var t in linq2)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Linq3:");
            foreach (var t in linq3)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Linq4:");
            foreach (var t in linq4)
            {
                foreach (var x in t)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
