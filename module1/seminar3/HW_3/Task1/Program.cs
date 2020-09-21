using System;

namespace Task1
{
    class Program
    {
        public static void A()
        {
            int a = 1;
            int sum = 0;
            while(true)
            {
                sum = sum + a;
                if (sum%10==(sum/10)%10 && sum%10==((sum/10)/10)%10)
                {
                    Console.WriteLine("Полученное число: " + sum);
                    Console.WriteLine("Количество членов ряда: " + a);
                    Console.WriteLine($"sum = 1 + 2 + 3 + ... + {a - 2} + {a - 1} + {a}");
                    break;
                }
                a++;
            }
        }
        static void Main(string[] args)
        {
            A();
        }
    }
}
