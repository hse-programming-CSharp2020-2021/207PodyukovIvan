using System;

namespace Task1
{
    public delegate void SquareSizeChanged(double a);
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    class Square
    {
        public event SquareSizeChanged OnSizeChanged;
        Point p1;
        Point p2;
        public Square(double a, double b, double c, double d)
        {
            p1.X = a;
            p1.Y = b;
            p2.X = c;
            p2.Y = d;
        }
        public Point P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
                OnSizeChanged(Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)) / Math.Sqrt(2));
            }
        }
        public Point P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
                OnSizeChanged(Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)) / Math.Sqrt(2));
            }
        }
    }
    class Program
    {
        public static void SquareConsoleInfo(double A)
        {
            Console.WriteLine(A.ToString("F2"));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double y2 = double.Parse(Console.ReadLine());
            Square S = new Square(x1, y1, x2, y2);
            S.OnSizeChanged += SquareConsoleInfo;
            do
            {
                Console.WriteLine("Введите x2:");
                x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y2:");
                y2 = double.Parse(Console.ReadLine());
                S.P2 = new Point(x2, y2);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
