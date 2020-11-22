using System;

namespace Task2
{
    class Program
    {
        public static void FigArray(out Point[] points, out int numberOfCircles, out int numberOfSquares)
        {
            Random rand = new Random();
            numberOfCircles = rand.Next(0, 11);
            numberOfSquares = rand.Next(0, 11);
            points = new Point[numberOfCircles + numberOfSquares];
            for (int i = 0; i < points.Length; i++)
            {
                if (i < numberOfCircles)
                {
                    points[i] = new Circle(rand.Next(10, 100) + rand.NextDouble(), rand.Next(10, 100) + rand.NextDouble(), rand.Next(10, 100) + rand.NextDouble());
                }
                else
                {
                    points[i] = new Square(rand.Next(10, 100) + rand.NextDouble(), rand.Next(10, 100) + rand.NextDouble(), rand.Next(10, 100) + rand.NextDouble());
                }
            }
        }
        static void Main()
        {
            Point p = new Point();
            p.Display();
            Console.WriteLine("p.Area для Point = " + p.Area);
            p = new Circle(1, 2, 6);
            p.Display();
            Console.WriteLine("p.Area для Circle = " + p.Area);
            p = new Square(3, 5, 8);
            p.Display();
            Console.WriteLine("p.Area для Square = " + p.Area);
            Point[] points;
            int numberOfCircles;
            int numberOfSquares;
            FigArray(out points, out numberOfCircles, out numberOfSquares);
            double areaOfCircles = 0;
            double perimeterOfCircles = 0;
            double areaOfSquares = 0;
            double perimeterOfSquares = 0;
            double[] areas = new double[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                areas[i] = points[i].Area;
                if (i < numberOfCircles)
                {
                    areaOfCircles += points[i].Area;
                    perimeterOfCircles += ((Circle)points[i]).Len;
                }
                else
                {
                    areaOfSquares += points[i].Area;
                    perimeterOfSquares += ((Square)points[i]).Len;
                }
            }
            Console.WriteLine($"Количество кругов = {numberOfCircles}, средняя их площадь = {(areaOfCircles / numberOfCircles):f3}, средний их периметр = {(perimeterOfCircles / numberOfCircles):f3}");
            Console.WriteLine($"Количество кругов = {numberOfSquares}, средняя их площадь = {(areaOfSquares / numberOfSquares):f3}, средний их периметр = {(perimeterOfSquares / numberOfSquares):f3}");
            Array.Sort(areas, points);
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Display();
            }
        }
    }
}
