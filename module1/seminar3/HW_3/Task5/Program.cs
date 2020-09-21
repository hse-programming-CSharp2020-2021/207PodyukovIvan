using System;

namespace Task5
{
    class Program
    {
        public static double G(double X)
        {
            if (X<=0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else
            {
                return Math.Sin((Math.PI * (X - 1)) / 2);
            }
        }
        static void Main(string[] args)
        {
            double x;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine(G(x).ToString("F3"));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
