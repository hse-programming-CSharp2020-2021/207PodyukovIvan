using System;

namespace Task5
{
    public delegate void Del();
    class Methods
    {
        static Random rand = new Random();
        public static event Del methodEvent;
        public static void Method1(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                methodEvent?.Invoke();
            }
        }
        public static void Method2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 100);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] arr = new int[rand.Next(5, 10), rand.Next(5, 10)];
            Methods.Method2(arr);
            Methods.methodEvent += () => Console.WriteLine();
            Methods.Method1(arr);
            Console.WriteLine();
            Methods.methodEvent += () => Console.WriteLine("****");
            Methods.Method1(arr);
        }
    }
}
