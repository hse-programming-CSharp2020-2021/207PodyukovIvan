using System;

namespace Task4
{
    class Program
    {
        public static double G(double X, double Y)
        {
            if (X < Y && X > 0)
            {
                return X + Math.Sin(Y);
            }
            else if (X > Y && X < 0)
            {
                return Y - Math.Cos(X);
            }
            else
            {
                return 0.5 * X * Y;
            }
        }
        static void Main(string[] args)
        {
            double x, y;
            if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine($"{ G(x, y):F3}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
