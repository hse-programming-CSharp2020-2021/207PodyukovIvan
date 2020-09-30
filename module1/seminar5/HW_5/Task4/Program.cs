using System;

namespace Task4
{
    class Program
    {
        public static void F(int[] arr)
        {
            int j = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = j;
                j += 2;
                Console.Write(arr[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            int N;
            if (int.TryParse(Console.ReadLine(), out N) && N > 0)
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
