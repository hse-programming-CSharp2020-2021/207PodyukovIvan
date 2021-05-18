using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Print(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(rand.Next(-10000, 10001));
            }
            Print(list);
            var a1 = list.Select(x => Math.Abs(x) % 10).ToList();
            Print(a1);
            var a2 = (from x in a1
                     orderby x
                     select x).ToList();
            Print(a2);
            int count = list.Where(x => x > 0 && x % 2 == 0).Count();
            Console.WriteLine(count);
            int sum = list.Where(x => x % 2 == 0).Aggregate((x, y) => x + y);
            Console.WriteLine(sum);
            var a3 = (from x in list
                      orderby (int)Math.Abs(x).ToString()[0]
                      select x).ThenBy(x => Math.Abs(x) % 10).ToList();
            Print(a3);
                    
        }
    }
}
