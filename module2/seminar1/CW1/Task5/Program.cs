using System;

namespace Task5
{
    class Program
    {
        public static void PrintArray(int[][] arr)
        {
            foreach (int[] arr1 in arr)
            {
                foreach (int item in arr1)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public static void GenerateArray(int[][] arr)
        {
            arr[0] = new int[1] { 1 };
            arr[1] = new int[2] { 1, 1 };
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    if (j != 0 && j != i)
                    {
                        arr[i][j] = arr[i - 1][j - 1] + arr[i - 1][j];
                    }
                    else
                    {
                        arr[i][j] = 1;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер треугольника Паскаля:");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
            {
                int[][] arr = new int[n][];
                GenerateArray(arr);
                PrintArray(arr);
            }
            else
            {
                Console.WriteLine("incorrect Input");
            }
            
        }
    }
}
