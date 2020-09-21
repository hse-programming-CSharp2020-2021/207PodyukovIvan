using System;
using System.Globalization;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;
            int p;
            if (double.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out p))
            {
                double a = b * p / 100;
                Console.WriteLine(a.ToString("C3",new CultureInfo("en-US")));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
