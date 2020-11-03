using System;
using System.Globalization;

namespace Task8
{
    class Schedule
    {
        public static string[] daysOfWeek = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public Schedule()
        {

        }
        public string this[int number]
        {
            get
            {
                return (number >= 1 && number <= 7) ? daysOfWeek[number - 1] : "Не существует такого дня недели";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"День недели под номером {i} - {schedule[i]}");
            }
        }
    }
}
