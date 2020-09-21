using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            if (!int.TryParse(Console.ReadLine(), out a) || a < 1000 || a > 9999)
            {
                Console.WriteLine("error");
            }
            else
            {
                string s = "";
                s = s + a % 10;
                a = a / 10;
                s = s + a % 10;
                a = a / 10;
                s = s + a % 10;
                a = a / 10;
                s = s + a % 10;
                Console.WriteLine(s);
           }
        }
    }
}
