using System;

namespace Task3
{
    class Program
    {
        public static void F(double[] arr)
        {
            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = Math.Pow(2, i);
                Console.Write(arr[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            int N;
            if (int.TryParse(Console.ReadLine(), out N) && N>0)
            {
                double[] arr = new double[N];
                F(arr);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
