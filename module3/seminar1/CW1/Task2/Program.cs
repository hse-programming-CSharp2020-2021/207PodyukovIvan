using System;

namespace Task2
{
    class Program
    {
        public static int[] Method1(int number)
        {
            int[] arr = new int[number.ToString().Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = number % 10;
                number = number / 10;
            }
            return arr;
        }
        public static void Method2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        delegate int[] Del1(int x);
        delegate void Del2(int[] arr);
        static void Main(string[] args)
        {
            Del1 d1 = Method1;
            Del2 d2 = Method2;
            int a = 39854;
            int[] arr1 = new int[] { 45, 23, 98, 23, 89, 34, 78, 53, 21, 12 };
            int[] arr2 = d1?.Invoke(a);
            d2?.Invoke(arr1);
            d2?.Invoke(arr2);
            Console.WriteLine(d1.Target);
            Console.WriteLine(d1.Method);
            Console.WriteLine(d2.Target);
            Console.WriteLine(d2.Method);
        }
    }
}
