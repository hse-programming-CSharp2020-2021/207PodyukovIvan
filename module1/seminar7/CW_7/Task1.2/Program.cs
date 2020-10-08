using System;
using System.IO;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = File.ReadAllText("../../../../IntNumber.txt");
            int x = 0;
            for (int i = 0; i < s.Length; i++)
            {
                x = x + (int)(int.Parse(s[i].ToString()) * Math.Pow(2, s.Length - i - 1));
            }
            Console.WriteLine(x);
            Console.WriteLine(new string('0', 32 - s.Length) + s);
        }
    }
}
