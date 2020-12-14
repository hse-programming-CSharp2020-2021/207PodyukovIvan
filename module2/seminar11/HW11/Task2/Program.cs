using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Methods.ValidatedSplit(Console.ReadLine(), ';');
            if (arr == null)
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                foreach (string str in arr)
                {
                    Console.WriteLine(Methods.Abbrevation(str));
                }
            }
        }
    }
}
