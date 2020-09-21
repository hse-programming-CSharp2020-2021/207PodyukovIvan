using System;

namespace Task1
{
    class Program
    {
        public static double F(double x)
        {
            return x*x*12*(x+1)*(x-0.25)+2*x-4;
        }
        static void Main(string[] args)
        {
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                double b = F(a);
                Console.WriteLine($"{b:F3}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
