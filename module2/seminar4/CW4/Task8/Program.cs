using System;
using System.Numerics;

namespace Task8
{
    class Point
    {
        double x;
        double y;
        public double DistanceToPoint(double x, double y)
        {
            return Math.Sqrt(Math.Pow((X - x), 2) + Math.Pow((Y - y), 2));
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            string str = X + "," + Y;
            return str;
        }
    }
    class Triangle
    {
        Point p1;
        Point p2;
        Point p3;
        public bool IsCorrect()
        {
            double a = p1.DistanceToPoint(p2.X, p2.Y);
            double b = p1.DistanceToPoint(p3.X, p3.Y);
            double c = p2.DistanceToPoint(p3.X, p3.Y);
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            }
        }
        public Point P3
        {
            get
            {
                return p3;
            }
            set
            {
                p3 = value;
            }
        }
        public double Square
        {
            get
            {
                double a = p1.DistanceToPoint(p2.X, p2.Y);
                double b = p1.DistanceToPoint(p3.X, p3.Y);
                double c = p2.DistanceToPoint(p3.X, p3.Y);
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public double Perimeter
        {
            get
            {
                return p1.DistanceToPoint(p2.X, p2.Y) + p1.DistanceToPoint(p3.X, p3.Y) + p2.DistanceToPoint(p3.X, p3.Y);
            }
        }
        public Triangle()
        {
            p1 = new Point();
            p2 = new Point();
            p3 = new Point();
        }
        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
        }
        public override string ToString()
        {
            string str = ($"Вершина a имеет координаты: ({p1})\nВершина b имеет координаты: ({p2})\nВершина c имеет координаты: ({p3})");
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Random rand = new Random();
                int N = rand.Next(5, 16);
                Triangle[] triangles = new Triangle[N];
                Console.WriteLine("Все треугольники:");
                double[] squares = new double[N];
                for (int i = 0; i < N; i++)
                {
                    do
                    {
                        triangles[i] = new Triangle(rand.Next(-10, 11), rand.Next(-10, 11), rand.Next(-10, 11), rand.Next(-10, 11), rand.Next(-10, 11), rand.Next(-10, 11));
                    } while (!triangles[i].IsCorrect());
                    squares[i] = triangles[i].Square;
                    Console.WriteLine("Треугольник №" + (i + 1));
                    Console.WriteLine(triangles[i]);
                }
                Console.WriteLine("Эти же треугольники, но расположенные по убыванию их площади");
                for (int i = 0; i < N; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (squares[i] > squares[j])
                        {
                            Triangle temp = triangles[i];
                            triangles[i] = triangles[j];
                            triangles[j] = temp;
                            double temp1 = squares[i];
                            squares[i] = squares[j];
                            squares[j] = temp1;
                        }
                    }
                }
                for (int i = N - 1; i >= 0; i--)
                {
                    Console.WriteLine("Треугольник №" + (N - i));
                    Console.WriteLine(triangles[i]);
                    Console.WriteLine($"S{i + 1} = {squares[i]:F3}");
                }
                Console.WriteLine("Нажмите Escape, чтобы выйти из программы. Для продолжения нажмите любую другую клавишу...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
