using System;

namespace Task5
{
    class Program
    {
        public static void F(int[] arr, int A, int D)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = A + i*D;
                Console.Write(arr[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            int N, A, D;
            if (int.TryParse(Console.ReadLine(), out N) && N > 1 && int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out D))
            {
                int[] arr = new int[N];
                F(arr,A,D);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
