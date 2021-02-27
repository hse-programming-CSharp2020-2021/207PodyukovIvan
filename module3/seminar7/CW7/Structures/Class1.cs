using System;
using System.Diagnostics.CodeAnalysis;

namespace Structures
{
    struct Point 
    {
        double x;
        double y;
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
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2));
        }
        public override string ToString()
        {
            return $"x = {x}, y = {y}";
        }
    }
    struct Circle : IComparable<Circle>
    {
        Point centre;
        public Point Centre
        {
            get
            {
                return centre;
            }
            set
            {
                centre = value;
            }
        }
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
        public double Length
        {
            get
            {
                return Math.PI * 2 * rad;
            }
        }
        public Circle(double x, double y, double rad)
        {
            this.rad = rad;
            centre = new Point(x, y);
        }
        public int CompareTo(Circle other)
        {
            return rad.CompareTo(other.rad);
        }
        public override string ToString()
        {
            return $"Radius = {rad}. Length = {Length}. {centre}";
        }
    }
}
