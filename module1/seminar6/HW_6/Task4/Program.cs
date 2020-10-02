using System;

namespace Task4
{
    class Program
    {
        // 4.1.
        public static int[] Form(int a0)
        {
            // Вычисление длины массива.
            int b = a0;
            int b1 = 0;
            int length = 0;
            while (b1 != 1)
            {
                b1 = b % 2 == 0 ? (b / 2) : (3 * b + 1);
                b = b1;
                length++;
            }
            int[] arr = new int[length];
            arr[0] = a0;
            for (int i = 1; i < length; i++)
            {
                arr[i] = arr[i - 1] % 2 == 0 ? (arr[i - 1] / 2) : (3 * arr[i - 1] + 1);
            }
            return arr;
        }
        // 4.2.
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{i}] = {arr[i]} \t");
                if (i % 5 == 4)
                {
                    Console.WriteLine();
                }
            }
        }
        // 4.3.
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int a0))
            {
                int[] arr = Form(a0);
                Print(arr);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
