using System;

namespace Task3
{
    class Program
    {
        public static bool G(double X, double Y)
        {
            if (X * X + Y * Y <= 4 && Y <= X && X >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            double x, y;
            if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(G(x,y));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
