using System;

namespace Task1
{
    class Program
    {
        // 8.1.
        public static double[] m(int N)
        {
            double[] arr = new double[N];
            for (int i=0;i<N;i++)
            {
                arr[i] = (i * (i - 1)/2) % N;
            }
            return arr;
        }
        // 8.2.
        public static double[] norm(double[] arr)
        {
            double max = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (Math.Abs(arr[i])>Math.Abs(max))
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] / max;
            }
            return arr;
        }
        // 8.3.
        public static void print(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString("F3")+"\t");
            }
        }
        // 8.4.
        static void Main(string[] args)
        {
            int N;
            if (int.TryParse(Console.ReadLine(),out N) && N>0)
            {
                double[] arr = m(N);
                print(arr);
                Console.WriteLine();
                arr = norm(arr);
                print(arr);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
