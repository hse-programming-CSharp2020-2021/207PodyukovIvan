using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            if (!int.TryParse(Console.ReadLine(), out a) || a<100||a>999)
            {
                Console.WriteLine("error");
            }
            else
            {
                int x = a % 10;
                a = a / 10;
                int y = a % 10;
                a = a / 10;
                int z = a % 10;
                a = 100 * z + 10 * y + x;
                int t1, t2, t3;
                t1 = x > y ? (x > z ? x : z) : (y > z ? y : z);
                t3 = x < y ? (x < z ? x : z) : (y < z ? y : z);
                t2 = x + y + z - t1 - t3;
                a = 100 * t1 + 10 * t2 + t3;
                Console.WriteLine(a);
            }
        }
    }
}
