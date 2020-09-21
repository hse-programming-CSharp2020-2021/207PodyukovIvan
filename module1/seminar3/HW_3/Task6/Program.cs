using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c) && a >= 100 && a <= 999 && b >= 100 && b <= 999 && c >= 100 && c <= 999)
            {
                int a1 = a % 100;
                int b1 = b % 100;
                int c1 = c % 100;
                if (a1<=b1)
                {
                    if (a1<=c1)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
                else
                {
                    if (b1 <= c1)
                    {
                        Console.WriteLine(b);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
