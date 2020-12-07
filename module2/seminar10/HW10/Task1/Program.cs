using System;
public static class Methods
{
    public static int GetIntValue(string comment)
    {
        Console.Write(comment);
        return int.Parse(Console.ReadLine());
    }
}
public class Matrix
{
    int[,] matrix;
    // Получение значения целочисленного параметра
    public void MatrPrint()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public Matrix UnitMatr(int n)
    {// Сформировать единичную матрицу:
        if (n <= 0)
            throw new ArgumentOutOfRangeException("Аргумент метода должен быть положительным!");
        matrix = new int[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = (i == j ? 1 : 0);
        return this;
    }
}
public class Program
{
    public static void Main()
    {
        Matrix res; // ссылка на двумерный массив (матрица)
        int rank; // Порядок матрицы
        do
        { // цикл повторения решений
            try
            {
                rank = Methods.GetIntValue("Введите порядок матрицы: ");
                res = new Matrix().UnitMatr(rank);
                res.MatrPrint();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Для завершения программы нажмите ESC");
            }
            catch (ArgumentNullException e1)
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine("Ошибка! Передано значение null");
            }
            catch (FormatException e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine("Должно быть введено целое число! Некорректный ввод");
            }
            catch (OverflowException e3)
            {
                Console.WriteLine(e3.Message);
                Console.WriteLine("Переполнение!");
            }
            Console.WriteLine("Для завершения программы нажмите ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    } // Main( )
}

