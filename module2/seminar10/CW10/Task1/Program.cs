using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Clear();

                Console.WriteLine("Введите номер исключения!");
                Console.WriteLine("1)ArgumentException\n2)InvalidOperationException\n3)NullReferenceException");
                Console.WriteLine("4)ArgumentNullException\n5)FormatException\n6)DivideByZeroException\n7)IOException");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 7);
            switch (n)
            {
                case 1:
                    string str = "fggf";
                    int a = 0;
                    str.CompareTo(a);
                    break;
                case 2:
                    List<int> list = new List<int>() { 2, 34, 6, 4, 2 };
                    foreach (int i in list)
                    {                       
                        list.Add(34);
                    }
                    break;
                case 3:
                    int[][] arr = new int[2][];
                    int g = arr[0].Length;
                    break;
                case 4:
                    string s = null;
                    int d = int.Parse(s);
                    break;
                case 5:
                    string s1 = "ggr";
                    int d1 = int.Parse(s1);
                    break;
                case 6:
                    int w = 0;
                    int d2 = 5 / w;
                    break;
                case 7:
                    File.ReadAllLines("6.txt");
                    break;

            }
        }
    }
}
