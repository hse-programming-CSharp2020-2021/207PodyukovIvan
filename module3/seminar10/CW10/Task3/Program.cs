using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] arr = new string[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = (rand.NextDouble() + rand.Next(100, 1000)).ToString();
            }
            File.WriteAllLines("test.txt", arr);
            StreamReader sr = new StreamReader("test.txt");
            Console.SetIn(sr);
            double sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum = sum + double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Среднее значение = " + sum / 100);
            Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        }
    }
}
