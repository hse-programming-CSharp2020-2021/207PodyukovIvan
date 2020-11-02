using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading;

public class Polygon { // Класс многоугольников
    int numb;		// Число сторон
    double radius;	// Радиус вписанной окружности
    public Polygon(int n = 3, double r = 1)
    { // конструктор       
        numb = n;
        radius = r;
    }
    public double Perimeter { // Периметр многоугольника - свойство
        get {   // аксессор свойства
            double term = Math.Tan(Math.PI / numb);
            return 2 * numb * radius * term;
        }
    }

    public double Area { // Площадь многоугольника - свойство
        get {   // аксессор свойства
            return Perimeter * radius / 2;
        }
    }
    public string PolygonData()
    {
        string res =
        string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
        numb, radius, Perimeter, Area);
        return res;
    }
}   // Polygon 
public class Program
{
    public static void Main()
    {
        do
        {
            Console.Clear();
            double rad;
            int number;
            List<Polygon> polygons = new List<Polygon>();
            List<double> S = new List<double>();
            int k = 1;
            do
            {
                do Console.Write("Введите число сторон: ");
                while (!int.TryParse(Console.ReadLine(), out number) | (number < 3 && number != 0));
                do Console.Write("Введите радиус: ");
                while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
                polygons.Add(new Polygon(number, rad));
                S.Add(polygons[polygons.Count - 1].Area);
                List<double> S1 = new List<double>(S);
                S1.Sort();
                for (int i = 0; i < polygons.Count; i++)
                {
                    if (polygons[i].Area == S1[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (polygons[i].Area == S1[S1.Count - 1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(i + 1 + " многоугольник : " + polygons[i].PolygonData());
                    Console.ResetColor();
                }
                k++;
            } while (rad != 0 && number != 0);
            Console.WriteLine("Для выхода нажмите клавишу ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

    }
}
