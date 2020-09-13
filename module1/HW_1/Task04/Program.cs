using System;
using System.Runtime.InteropServices;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U = double.Parse(Console.ReadLine());
            double R = double.Parse(Console.ReadLine());
            double I = U / R;
            double P = U * U / R;
            Console.WriteLine("I = " + I);
            Console.WriteLine("P = " + P);
        }
    }
}
