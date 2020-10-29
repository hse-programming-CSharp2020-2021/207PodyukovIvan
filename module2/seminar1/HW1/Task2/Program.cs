using System;

namespace Task2
{
	class Program
	{
		static void Main()
		{
			int N;
			do
			{
				Console.Write("Введите N: ");
			}
			while (!int.TryParse(Console.ReadLine(), out N) || N < 1);
			int[,] arr = new int[N, N];
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					arr[i, j] = (i + j) % N + 1;
					Console.Write(arr[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}

