using System;

namespace Task3
{
    class Program
    {
        // Факториал числа.
        public static int Fact(int fact)
        {
            int mult = 1;
            for (int i = 1; i <= fact; i++)
            {
                mult = mult * i;
            }
            return mult;
        }
        // 3.1.
        public static double[] Sin1(int N)
        {
            double[] arr = new double[N];
            arr[0] = 1.0;
            int fact = 3;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = -arr[i - 1] / Fact(fact);
                fact += 2;
            }
            return arr;
        }
        // 3.2.
        public static double SinX(double x, double[] arr)
        {
            int pow = 1;
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * Math.Pow(x, pow);
                sum = sum + arr[i];
                pow += 2;
            }
            return sum;
        }
        // 3.3.
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                double[] arr = Sin1(N);
                Console.Write("Введите X: ");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    Console.WriteLine(Math.Sin(x));
                    Console.WriteLine(SinX(x, arr));
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
