using System;

namespace Task2
{ 
    struct Coords
    {
        double x;
        double y;
        public Coords(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"x = {x}, y = {y}";
        }
    }
    class Circle
    {
        double radius;
        Coords center;
        public Coords Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус должен быть положительным числом!");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle(double x, double y, double radius)
        {
            Radius = radius;
            center = new Coords(x, y);
        }
        public override string ToString()
        {
            return $"Radius = {radius}. {center}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle circle1 = new Circle(8.6, 4, 5);
                Console.WriteLine(circle1);
                Circle circle2 = new Circle(-4, 5.6, -7);
                Console.WriteLine(circle2);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
