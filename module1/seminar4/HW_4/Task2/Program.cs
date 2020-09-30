using System;
using System.IO;

namespace Task2
{
    // Задача 7 из презентации 4-ого семинара.
    class Program
    {
        public static void F(out int nok, out int nod, int a, int b)
        {
            nok = a * b;
            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            nod = a;
            nok = nok / nod;
        }
        static void Main(string[] args)
        {
            int a, b;
            if (int.TryParse(Console.ReadLine(),out a)&& int.TryParse(Console.ReadLine(), out b)&&a>0&&b>0)
            {
                int nok, nod;
                F(out nok, out nod, a, b);
                Console.WriteLine("НОК = " + nok);
                Console.WriteLine("НОД = " + nod);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
