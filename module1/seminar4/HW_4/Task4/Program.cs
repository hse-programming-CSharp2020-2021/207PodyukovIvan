using System;

namespace Task4
{
    // Задание 2 со слайда 10 из презентации 4-ого семинара.
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 0;
            int x;
            do
            {
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if (x < 0)
                    {
                        sum = sum + x;
                        n++;
                    }
                }
                else
                {
                    break;
                }
            } while (sum >= -1000);
            if (n != 0)
            {
                Console.WriteLine((double)(sum / n));
            }
            else
            {
                Console.WriteLine("Отрицательных чисел не было!");
            }
        }
    }
}
