using System;

namespace Task6
{
    class Program
    {
        // 6.1.
        public static int[] F1(ref int[] arr, ref int count)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] = arr[i] * arr[i + 1];
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize<int>(ref arr, arr.Length - 1);
                    count++;
                }
            }
            return arr;
        }
        // 6.2.
        public static int F2(ref int[] arr)
        {
            int count = 0;
            int lastcount = 0;
            do
            {
                lastcount = count;
                F1(ref arr, ref count);

            } while (lastcount != count);
            return count;
        }
        static void Main(string[] args)
        {

            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                Random rand = new Random();
                int[] arr = new int[N];
                Console.Write("Исходный массив :");
                for (int i = 0; i < N; i++)
                {
                    arr[i] = rand.Next(-10, 11);
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                int count = F2(ref arr);
                Console.Write("Конечный массив :");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
                Console.Write("Количество сжатий : " + count);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
