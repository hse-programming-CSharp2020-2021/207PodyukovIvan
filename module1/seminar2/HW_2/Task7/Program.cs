using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Task7
{
    class Program
    {
        public static void A(double x, ref int cel, ref double drob)
        {
            cel = (int)x;
            drob = Math.Abs(x - cel);
        }
        public static void B(double x, ref double sqrt, ref double kv)
        {
            if (x >= 0)
            {
                sqrt = Math.Sqrt(x);
            }
            kv = x * x;
        }
        public static void Main(string[] args)
        {
            double a;
            double sqrt = -1;
            double kv = -1;
            int cel=0;
            double drob=0;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                A(a, ref cel, ref drob);
                B(a, ref sqrt, ref kv);
                Console.WriteLine("Целая часть числа: " + cel);
                Console.WriteLine($"Дробная часть числа: {drob:F3}");
                if (sqrt<0)
                {
                    Console.WriteLine("Квадратного корня не существует");
                }
                else
                {
                    Console.WriteLine($"Квадратный корень из числа: {sqrt:F3}");
                }
                Console.WriteLine($"Квадрат числа: {kv:F3}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
    
    

