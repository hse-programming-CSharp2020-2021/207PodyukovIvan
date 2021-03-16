using System;
using System.Diagnostics.CodeAnalysis;

namespace Task4
{
    struct Rectangle : IComparable<Rectangle>
    {
        double a;
        double b;
        public double S
        {
            get
            {
                return a * b;
            }
        }
        public int CompareTo([AllowNull] Rectangle other)
        {
            return S.CompareTo(other.S);
        }
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return $"S = {S}, a = {a}, b = {b}";
        }
    }
    class Block3D : IComparable<Block3D>
    {
        Rectangle rect;
        double h;
        public int CompareTo([AllowNull] Block3D other)
        {
            return rect.CompareTo(other.rect);
        }
        public Block3D(double h, Rectangle rect)
        {
            this.h = h;
            this.rect = rect;
        }
        public override string ToString()
        {
            return $"h = {h}. {rect}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Block3D[] blocks = new Block3D[rand.Next(5, 10)];
            for (int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new Block3D(rand.Next(1, 20), new Rectangle(rand.Next(3, 30), rand.Next(3, 30)));
            }
            Array.Sort(blocks);
            Array.ForEach(blocks, (x) => Console.WriteLine(x));
        }
    }
}
