using System;

namespace Task10
{
    class Circle
    {
        double x;
        double y;
        double r;
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
        public double R
        {
            get
            {
                return r;
            }
        }
        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public bool IfIntersect(Circle circle)
        {
            if (Math.Sqrt(Math.Pow(X - circle.X, 2) + Math.Pow(Y - circle.Y, 2)) <= R + circle.R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Координаты центра окружности : ({X},{Y}) , radius = {R}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int N;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите N:");
                } while (!int.TryParse(Console.ReadLine(), out N) && N >= 1);
                Random rand = new Random();
                Circle[] circles = new Circle[N];
                Circle circle = new Circle(rand.Next(1, 16), rand.Next(1, 16), rand.Next(1, 16));
                Console.WriteLine("Главная окружность circle: " + circle);
                Console.WriteLine("Созданные окружности:");
                for (int i = 0; i < N; i++)
                {
                    circles[i] = new Circle(rand.Next(1, 16), rand.Next(1, 16), rand.Next(1, 16));
                    Console.WriteLine((i + 1) + ". " + circles[i]);
                }
                Console.WriteLine("Окружности, пересекающиеся с circle:");
                for (int i = 0; i < N; i++)
                {
                    if (circles[i].IfIntersect(circle))
                    {
                        Console.WriteLine((i + 1) + ". " + circles[i].ToString());
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Для выхода из программы нажмите Escape, для продолжения - любую другую клавишу...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

