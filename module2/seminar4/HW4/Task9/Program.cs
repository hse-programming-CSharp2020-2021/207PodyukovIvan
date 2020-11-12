using System;

namespace Task9
{
    class LinearEquation
    {
        int a;
        int b;
        int c;
        double solution;
        public double Solution
        {
            get
            {
                return solution;
            }
        }
        public LinearEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string FindSolution()
        {
            if (a == 0)
            {
                if (c - b == 0)
                {
                    solution = double.MaxValue;
                    return "решений бесконечно много";
                }
                else
                {
                    solution = double.MinValue;
                    return "решений нет";
                }
            }
            else
            {
                solution = (c - b) / a;
                return $"x = {solution}";
            }
        }
        public override string ToString()
        {
            return $"Уравнение {a} * x + {b} = {c} , " + FindSolution();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int N;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите N:");
                } while (!int.TryParse(Console.ReadLine(), out N) && N >= 1);
                Random rand = new Random();
                LinearEquation[] linearEquation = new LinearEquation[N];
                double[] solution = new double[N];
                for (int i = 0; i < N; i++)
                {
                    linearEquation[i] = new LinearEquation(rand.Next(-10, 11), rand.Next(-10, 11), rand.Next(-10, 11));
                    Console.WriteLine((i + 1) + ". " + linearEquation[i].ToString());
                    solution[i] = linearEquation[i].Solution;
                }
                Console.WriteLine("Отсортированный массив по возрастанию корней линейного уравнения:");
                Array.Sort(solution, linearEquation);
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine((i + 1) + ". " + linearEquation[i].ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Для выхода из программы нажмите Escape, для продолжения - любую другую клавишу...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
