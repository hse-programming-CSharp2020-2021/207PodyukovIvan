using System;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            if (double.TryParse(Console.ReadLine(),out a)&& double.TryParse(Console.ReadLine(), out b)&& double.TryParse(Console.ReadLine(), out c))
            {
                string result = "";
                string x = "Такой треугольник существует", y = "Такого треугольника не существует";
                result = (a + b) > c ? ((a + c) > b ? ((b + c) > a ? x : y) : y) : y;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
