using System;
using System.Security.Cryptography.X509Certificates;

namespace Task3
{
    class Program
    {
        public static void A(double b, double c)
        {
            switch(b)
            {
                case 0:
                    switch (c)
                    {
                        case 0:
                            Console.WriteLine("Бесконечное число решений");
                            break;
                        default:
                            Console.WriteLine("Корней нет");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"x = {(-c / b):F3}");
                    break;
            }
           
        }
        public static void B(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            int check3 = (d > 0) ? 2 : ((d == 0) ? 1 : 0); //переменная для разных случаев, рассматриваемых в switch
            switch (check3)
            {
                case 2:
                    Console.WriteLine($"x1 = {((-b + Math.Sqrt(d)) / (2 * a)):F3}");
                    Console.WriteLine($"x2 = {((-b - Math.Sqrt(d)) / (2 * a)):F3}");
                    break;
                case 1:
                    Console.WriteLine($"x = {(-b / (2 * a)):F3}");
                    break;
                case 0:
                    Console.WriteLine("Корней нет");
                    break;
            }
        }
        static void Main(string[] args)
        {
            
            double a=0, b=0, c=0;
            Console.WriteLine("Введите a, b и c");
            bool check1 = double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c);
            switch (check1)
            {
                case true:
                    int check2 = (a == 0) ? 0 : 1;
                    switch(check2)
                    {
                        case 0:
                            A(b, c);
                            break;
                        case 1:
                            B(a, b,  c);
                            break;
                    }
                    break;
                case false:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
