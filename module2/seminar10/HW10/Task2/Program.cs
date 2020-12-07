using System;

public class GeomProgr
{
    // поле класса - счетчик созданных объектов: 
    public static uint objectNumber = 0;
    double _b; // первый член прогрессии b!=0
    double _q; // знаменатель прогрессии q!=0
    public double B
    {
        get { return _b; }
        set
        {
            if (value == 0)
                throw new Exception("Недопустимое значение первого члена прогрессии!");
            _b = value;
        }
    }
    public double Q
    {
        get { return _q; }
        set
        {
            if (value == 0)
                throw new Exception("Недопустимое значение знаменателя прогрессии!");
            _q = value;
        }
    }

    // Конструкторы 
    // методы для "работы" с объектами класса
    // Конструктор без параметров (конструктор умолчания):
    public GeomProgr()
    {
        _b = 1;
        _q = 1;
        objectNumber++;
        Console.WriteLine(objectNumber + ": Конструктор без параметров");
    }
    // Конструктор общего вида (конструктор с параметрами):
    public GeomProgr(double b, double q) : this()
    {
        if (b == 0 || q == 0)
        {
            objectNumber--;
            throw new Exception("Ошибка в аргументах конструктора!");
        }
        _b = b;
        _q = q;
        Console.WriteLine(objectNumber + ": Конструктор с параметрами");
    }

    public double this[int n]
    {
        get
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException("Индекс должен быть натуральным числом");
            }
            try
            {
                return _b * (Math.Pow(_q, (n - 1)));
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }
    }

    public double ProgrSum(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentOutOfRangeException("Индекс должен быть натуральным числом");
        }
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + this[i];
        }
        return sum;
    }

}
// end of class GeomProgr
class Program
{
    static void Main()
    {
        GeomProgr geomProgrObj; // ссылка на объект типа GeomProgr
        bool flag;
        int b, q;
        do
        {
            flag = false;
            try
            {
                Console.Write("Введите начальный член прогрессии: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Введите знаменатель прогрессии: ");
                q = int.Parse(Console.ReadLine());
                geomProgrObj = new GeomProgr(b, q); // создаем объект 2
                bool check = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Введите n");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("n-ый член прогрессии: " + geomProgrObj[n]);
                        Console.WriteLine("Сумма первых n членов прогрессии: " + geomProgrObj.ProgrSum(n));
                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine(e.Message);
                        check = false;
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.Message);
                        check = false;
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine(e.Message);
                        check = false;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        check = false;
                    }
                } while (!check);
            }
            catch (FormatException e)
            {
                flag = true;
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                flag = true;
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                flag = true;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                flag = true;
            }
            catch (Exception e)
            { // ловим любые исключения
                flag = true;
                Console.WriteLine("Некорректные входные данные! ");
            }
            
        } while (flag);
    }
}

