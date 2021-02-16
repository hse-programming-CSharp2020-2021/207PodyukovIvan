using System;

namespace Task1
{
    interface ICalculation
    {
        double Perform(double x);
    }
    class Add : ICalculation
    {
        double number;
        public Add(double a)
        {
            number = a;
        }
        public double Perform(double x)
        {
            return x + number;
        }
    }
    class Multiply : ICalculation
    {
        double number;
        public Multiply(double a)
        {
            number = a;
        }
        double ICalculation.Perform(double x)
        {
            return x * number;
        }
    }
    class Program
    {
        static double Calculate(double x, ICalculation ic1, ICalculation ic2)
        {
            return ic2.Perform(ic1.Perform(x));
        }
        static void Main(string[] args)
        {
            var x = Calculate(5, new Add(5), new Multiply(10.5));
            Console.WriteLine(x);
        }
    }
}
