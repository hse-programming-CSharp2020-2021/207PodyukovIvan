using System;
using System.Globalization;

class Birthday
{
    string name; // закрытое поле - фамилия
    int year, month, day; // Закрытые поля: год, месяц, день рождения
    public Birthday(string name, int y, int m, int d)
    { // Конструктор
        this.name = name;
        year = y; month = m; day = d;
    }
    public Birthday()
    {
        year = 1970;
        month = 1;
        day = 1;
    }
    DateTime Date
    { // закрытое свойство - дата рождения
        get { return new DateTime(year, month, day); }
    }
    public string Information
    {   // свойство - сведения о человеке
        get
        {
            return name + ", дата рождения " + day + ":" + month + ":" + year;
        }
    }
    public int HowManyDays
    { // свойство - сколько дней до дня рождения
        get
        {
            // номер сего дня от начала года:
            int nowDOY = DateTime.Now.DayOfYear;
            //  номер дня рождения от начала года: 
            int myDOY = Date.DayOfYear;
            int period = myDOY >= nowDOY ? myDOY - nowDOY :
                                           365 - nowDOY + myDOY;
            return period;
        }

    }
    public string DateOfBirthday1
    {
        get
        {
            return $"{day:00} " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month) + " " + year;
        }
    }
    public string DateOfBirthday2
    {
        get
        {
            return $"{day:00}-{month:00}-{year % 100:00}";
        }
    }
    class Program
    {
        static void Main()
        {
            Birthday md = new Birthday("Чапаев", 1887, 2, 9);
            Console.WriteLine(md.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(md.HowManyDays);

            Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);
            Console.WriteLine(km.Information);
            Console.WriteLine("До следующего дня рождения дней осталось: ");
            Console.WriteLine(km.HowManyDays);
        }
    }
}
