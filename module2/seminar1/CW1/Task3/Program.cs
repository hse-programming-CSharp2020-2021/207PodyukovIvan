using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] arr = new char[3][][];
            arr[0] = new char[3][];
            arr[1] = new char[2][];
            arr[2] = new char[1][];
            arr[0][0] = new char[2] {'a','b'};
            arr[0][1] = new char[3] { 'c', 'd','e' };
            arr[0][2] = new char[4] { 'f', 'g','h','i' };
            arr[1][0] = new char[2] { 'j', 'k' };
            arr[1][1] = new char[3] { 'i', 'm', 'n'};
            arr[2][0] = new char[4] { 'o', 'p', 'q','r' };
            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr[0].Rank);
            Console.WriteLine(arr);
            Console.WriteLine(arr[0][0].Rank);
            foreach (char[][] arr1 in arr)
            {
                foreach (char[] arr2 in arr1)
                {
                    foreach (char item in arr2)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
