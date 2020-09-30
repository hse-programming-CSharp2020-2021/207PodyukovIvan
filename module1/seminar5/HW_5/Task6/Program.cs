using System;

namespace Task6
{
    class Program
    {
        public static void F(int[] arr)
        {
            arr[0] = 1;
            arr[1] = 1;
            Console.Write(arr[0] + "\t");
            Console.Write(arr[1] + "\t");
            for (int i=2;i<arr.Length;i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                Console.Write(arr[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            int N;
            if (int.TryParse(Console.ReadLine(), out N) && N > 1)
            {
                int[] arr = new int[N];
                F(arr);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
