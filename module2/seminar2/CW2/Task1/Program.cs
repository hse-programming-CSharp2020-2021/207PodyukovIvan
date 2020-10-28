using System;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    class Circle
    {
        double _r;
        public double Radius
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius should be non-negative");
                _r = value;
            }
        }
        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }
        public double P
        {
            get
            {
                return 2 * Math.PI * _r;
            }
        }
        public Circle()
        {
            Radius = 1;
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public override string ToString()
        {
            return $"Circle: radius = {Radius:f3}, square = {S:f3}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество кругов:");
            if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
            {
                Console.WriteLine("Введите Rmin:");
                if (double.TryParse(Console.ReadLine(), out double rmin) && rmin > 0)
                {
                    Console.WriteLine("Введите Rmax:");
                    if (double.TryParse(Console.ReadLine(), out double rmax) && rmax > rmin)
                    {
                        Random rand = new Random();
                        Circle[] circles = new Circle[n];
                        double maxS = 0;
                        double temp;
                        int maxIndex = 0;
                        for (int i = 0; i < n; i++)
                        {

                            temp = rand.Next((int)rmin, (int)rmax) + rand.NextDouble();
                            while (temp > rmax)
                            {
                                temp = temp - 0.05;
                            }
                            while (temp < rmin)
                            {
                                temp = temp + 0.05;
                            }
                            circles[i] = new Circle(temp);
                            if (circles[i].S > maxS)
                            {
                                maxS = circles[i].S;
                                maxIndex = i;
                            }
                            Console.WriteLine(circles[i].ToString());
                        }
                        Console.WriteLine("Круг с наибольшей площадью:");
                        Console.WriteLine(circles[maxIndex].ToString());
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
