using System;

namespace Task6
{
    // Задание 4 со слайда 10 из презентации 4-ого семинара.
    class Program
    {
        public static ulong F(int n, int m)
        {
            return (ulong)((1 << n) + (1 << m));
        }
        static void Main(string[] args)
        {
            int n, m;
            if (int.TryParse(Console.ReadLine(), out n) && int.TryParse(Console.ReadLine(), out m) && n > 0 && m > 0 && n < 31 && m < 31)
            {
                Console.WriteLine(F(n, m));
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
