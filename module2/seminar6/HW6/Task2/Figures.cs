using System;

namespace Task2
{
    class Point
    {
        protected double x, y;
        public virtual void Display()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
        public virtual double Area { get; set; }
        public double Y { get; set; }
    }
    class Circle : Point
    {
        double rad;
        public double Rad
        {
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }
        }
        public double Len
        {
            get
            {
                return Math.PI * 2 * rad;
            }
        }
        public override void Display()
        {
            Console.WriteLine($"x = {x:f3}, y = {y:f3}, radius = {rad:f3}, area = {Area:f3}, len = {Len:f3}");
        }
        public override double Area
        {
            get
            {
                return Math.PI * rad * rad;
            }
        }
        public Circle(double x, double y, double rad)
        {
            Rad = rad;
            this.x = x;
            this.y = y;
        }
    }
    class Square : Point
    {
        double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public double Len
        {
            get
            {
                return side * 4;
            }
        }
        public override void Display()
        {
            Console.WriteLine($"x = {x:f3}, y = {y:f3}, side = {side:f3}, area = {Area:f3}, len = {Len:f3}");
        }
        public override double Area
        {
            get
            {
                return side * side;
            }
        }
        public Square(double x, double y, double side)
        {
            Side = side;
            this.x = x;
            this.y = y;
        }
    }
}
