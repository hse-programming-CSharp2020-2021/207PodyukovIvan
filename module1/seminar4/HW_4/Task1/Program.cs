using System;

namespace HW_4
{
    // Задача 6 из презентации 4-ого семинара.
    class Program
    {
        public static double S1(double a)
        {
            double result = 0;
            double result1 = 0;
            double b = -1;
            int i = 2;
            do
            {
                result1 = result;
                b = b * (-Math.Pow(2, (i - 1)));
                b = b * Math.Pow(a, i);
                double proizv = 1;
                for (int j = 1; j <= i; j++)
                {
                    proizv = proizv * j;
                }
                b = b / proizv;
                result = result + b;
                i = i + 2;
            } while (Math.Abs(result - result1) > 0.001);
            return result;
        }
        public static double S2(double a)
        {
            double result = 1;
            double result1 = 0;
            int i = 1;
            do
            {
                result1 = result;
                double b = Math.Pow(a, i);
                double proizv = 1;
                for (int j = 1; j <= i; j++)
                {
                    proizv = proizv * j;
                }
                b = b / proizv;
                result = result + b;
                i++;
            } while (Math.Abs(result - result1) > 0.001);
            return result;
        }
        static void Main(string[] args)
        {
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("S1 = " + S1(x));
                Console.WriteLine("S2 = " + S2(x));
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}