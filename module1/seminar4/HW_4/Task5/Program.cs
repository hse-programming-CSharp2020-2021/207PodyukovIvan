using System;

namespace Task5
{
    // Задание 3 со слайда 10 из презентации 4-ого семинара.
    class Program
    {
        public static void Y(double a,double b,double c)
        {
            double y;
            for (double x=1;x<2;x=x+0.05)
            {
                if (x<1.2)
                {
                    y = a * x * x + b * x + c;
                }
                else if (x==1.2)
                {
                    y = a / x + Math.Sqrt(x * x + 1);
                }
                else
                {
                    y = (a + b * x) / Math.Sqrt(x * x + 1);
                }
                Console.WriteLine("x = " + x.ToString("F3") + "\ty = " + y.ToString("F3"));
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            if (double.TryParse(Console.ReadLine(),out a)&& double.TryParse(Console.ReadLine(), out b)&&double.TryParse(Console.ReadLine(), out c))
            {
                Y(a, b, c);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
