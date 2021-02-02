using System;

namespace Task5
{
    delegate double Calculate(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc1 = (x) =>
            {
                double sum = 0;
                for (int i = 1; i <= 5; i++)
                {
                    double result = 1;
                    for (int j = 1; j <= 5; j++)
                    {
                        result = result * 1.0 * i * x / j;
                    }
                    sum = sum + result;
                }
                return sum;
            };
            Console.WriteLine(calc1(1));
        }
    }
}
