using System;

namespace Task2
{
    interface ISequence
    {
        double GetElement(int a);
    }
    class ArithmeticProgression : ISequence
    {
        double q, d;
        public double GetElement(int a)
        {
            return q + d * (a - 1);
        }
        public ArithmeticProgression(double q, double d)
        {
            this.q = q;
            this.d = d;
        }
    }
    class GeometricProgression : ISequence
    {
        double q, d;
        public double GetElement(int a)
        {
            return q * Math.Pow(d, a - 1);
        }
        public GeometricProgression(double q, double d)
        {
            this.q = q;
            this.d = d;
        }
    }
    class Program
    {
        static double Sum(ISequence isq, int a)
        {
            double sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum = sum + isq.GetElement(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticProgression(5,1),2));
        }
    }
}
