using System;
using System.Text;

namespace Task1
{
    class Program
    {
        public static StringBuilder sb;
        public static void Task1()
        {
            while (sb.ToString().Contains("  "))
            {
                sb.Replace("  ", " ");
            }
            Console.WriteLine(sb.ToString());
        }
        public static void Task2()
        {
            int i = 0;
            foreach (string word in sb.ToString().Split(' '))
            {
                if (word.Length > 4)
                {
                    i++;
                }
            }
            Console.WriteLine(i);
        }
        public static void Task3()
        {
            int i = 0;
            char[] chars = new char[] { 'а', 'о', 'у', 'я', 'э', 'ы', 'ю', 'е', 'ё', 'и' };
            foreach (string word in sb.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (word.ToLower()[0] == chars[j])
                    {
                        i++;
                        break;
                    }
                }
            }
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            sb = new StringBuilder(str);
            Task1();
            Task2();
            Task3();
        }
    }
}
