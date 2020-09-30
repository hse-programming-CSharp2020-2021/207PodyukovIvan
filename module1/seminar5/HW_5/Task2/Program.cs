using System;

namespace Task2
{
    class Program
    {
        // Задание 9 из презентации про массивы.
        public static double[] F(double[] arr, double N)
        {
            double max = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==max)
                {
                    arr[i] = N;
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            double N;
            double[] arr = new double[6] { 1.0, 0.2, 3.6, 7.7, 9.2, 11.2 };
            if (double.TryParse(Console.ReadLine(), out N))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "\t");
                }
                arr = F(arr, N);
                Console.WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "\t");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
