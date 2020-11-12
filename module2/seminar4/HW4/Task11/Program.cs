using System;

namespace Task11
{
    class GeometricProgression
    {
        double _start;
        double _increment;
        public double Increment
        {
            get
            {
                return _increment;
            }
        }
        public GeometricProgression()
        {
            _start = 0;
            _increment = 1;
        }
        public GeometricProgression(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }
        public double this[int index]
        {
            get
            {
                return _start * Math.Pow(_increment, index - 1);
            }
        }
        public string GetInfo()
        {
            return $"start = {_start}, increment = {_increment}";
        }
        public double GetSum(int n)
        {
            return _start * (1 - Math.Pow(_increment, n)) / (1 - _increment);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int N;              
                Random rand = new Random();
                N = rand.Next(5, 16);
                GeometricProgression[] geometricProgressions = new GeometricProgression[N];
                GeometricProgression geometricProgression;
                do
                {
                    geometricProgression = new GeometricProgression(rand.Next(0, 11), rand.Next(0, 6));
                } while (geometricProgression.Increment == 0);
                Console.WriteLine("Главная геометрическая прогрессия geometricProgression: " + geometricProgression.GetInfo());
                Console.WriteLine("Созданные геометрические прогрессии:");
                for (int i = 0; i < N; i++)
                {
                    do
                    {
                        geometricProgressions[i] = new GeometricProgression(rand.Next(0, 11), rand.Next(0, 6));
                    } while (geometricProgressions[i].Increment == 0);
                    Console.WriteLine((i + 1) + ". " + geometricProgressions[i].GetInfo());
                }
                int step = rand.Next(3, 16);
                Console.WriteLine("step = "+step);
                Console.WriteLine($"Прогрессии, у которых элемент с номером {step} больше соответствующего элемента главной прогрессии:");
                for (int i = 0; i < N; i++)
                {
                    if (geometricProgressions[i][step] > geometricProgression[step])
                    {
                        Console.WriteLine((i + 1) + ". " + geometricProgressions[i].GetInfo() + $", Sum({step}) = {geometricProgressions[i].GetSum(step)}");
                    }

                }
                Console.WriteLine();
                Console.WriteLine("Для выхода из программы нажмите Escape, для продолжения - любую другую клавишу...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
