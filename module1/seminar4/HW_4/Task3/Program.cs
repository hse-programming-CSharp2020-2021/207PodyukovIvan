using System;

namespace Task3
{
    // Задание 1 со слайда 10 из презентации 4-ого семинара.
    class Program
    {
        public static void F()
        {
            for (int i = 1; i < 20; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    for (int k = j + 1; k < 20; k++)
                    {
                        if (i * i + j * j == k * k)
                        {
                            Console.WriteLine("a = " + i + "\tb = " + j + "\tc = " + k);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            F();
        }
    }
}
