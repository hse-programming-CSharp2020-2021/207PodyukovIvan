using System;

namespace Task3
{
    interface IFigure
    {
        double S { get; }
    }
    class Square : IFigure
    {
        double side;
        public double S
        { 
            get => side * side;
        }
        public Square(double side)
        {
            this.side = side;
        }
        public override string ToString()
        {
            return $"Figure : Square. Side = {side}. S = {S}";
        }
    }
    class Circle : IFigure
    {
        double radius;
        public double S
        {
            get => Math.PI * radius * radius;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            return $"Figure: Circle. Radius = {radius}. S = {S}";
        }
    }
    class Program
    {
        static void PrintFigures<T>(T[] arr, double a) where T : IFigure
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].S > a)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            IFigure[] arr = new IFigure[rand.Next(5, 15)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    arr[i] = new Circle(rand.Next(1, 40));
                }
                else
                {
                    arr[i] = new Square(rand.Next(1, 40));
                }
            }
            PrintFigures(arr, 0);
            Console.WriteLine();
            int a = rand.Next(1, 2000);
            Console.WriteLine("Порог = " + a);
            PrintFigures(arr, a);
        }
    }
}
