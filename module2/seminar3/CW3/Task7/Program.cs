using System;

namespace Task7
{
    class Sin
    {
        double xmin;
        double xmax;
        public double Xmax
        {
            get
            {
                return xmax;
            }
            set
            {
                xmax = value;
            }
        }
        public double Xmin
        {
            get
            {
                return xmin;
            }
            set
            {
                xmin = value;
            }
        }
        public Sin(double xmin, double xmax)
        {
            Xmin = xmin;
            Xmax = xmax;
        }
        public double this[double sin]
        {
            get
            {
                return Math.Sin(sin);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sin sin = new Sin(0, Math.PI);
            double delta = Math.PI / 6;
            for (double i = sin.Xmin; i < sin.Xmax; i += delta)
            {
                Console.WriteLine(sin[i]);
            }
        }
    }
}
