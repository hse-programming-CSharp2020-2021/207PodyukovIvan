using System;
using System.Collections.Immutable;
// Задача 2 из презентации.
class Program
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания
                                        // СВОЙСТВО RO
                                        // СВОЙСТВО FI
        public string PointData
        {   // СВОЙСТВО 
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
        public double Ro
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Fi
        {
            get
            {
                if (X == 0 && Y == 0)
                {
                    return 0;
                }
                else if (X == 0 && Y < 0)
                {
                    return Math.PI * 1.5;
                }
                else if (X == 0 && Y > 0)
                {
                    return Math.PI / 2;
                }
                else if (X < 0)
                {
                    return Math.Atan(Y / X) + Math.PI;
                }
                else if (X > 0 && Y < 0)
                {
                    return Math.Atan(Y / X) + 2 * Math.PI;
                }
                else
                {
                    return Math.Atan(Y / X);
                }
            }
        }


        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                Console.WriteLine("Точки в порядке возрастания расстояний от них до начала координат:");
                Double[] arr = new double[3] { a.Ro, b.Ro, c.Ro };
                Array.Sort(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == a.Ro)
                    {
                        Console.WriteLine(a.PointData);
                    }
                    else if (arr[i] == b.Ro)
                    {
                        Console.WriteLine(b.PointData);
                    }
                    else
                    {
                        Console.WriteLine(c.PointData);
                    }
                }
                Console.WriteLine();
            } while (x != 0 | y != 0);


        }
    }
}

