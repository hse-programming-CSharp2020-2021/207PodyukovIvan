using System;

namespace Task1
{
    class UserString
    {
        string str;
        static Random gen = new Random();
        public UserString(int k, char minChar, char maxChar)
        {
            if (k < 0)
                throw new Exception("Аргумент метода должен быть положительным!");
            if (maxChar < minChar)
            {
                char c = minChar;
                minChar = maxChar;
                maxChar = c;
            }
            string line = String.Empty;
            for (int i = 0; i < k; i++)
                line += (char)gen.Next(minChar, maxChar + 1);
            str = line;
        }
        public void MoveOff(string s1)
        {
            int index;
            for (int i = 0; i < s1.Length; i++)
                while ((index = str.IndexOf(s1[i])) >= 0)
                    str = str.Remove(index, 1);
        }
        public override string ToString()
        {
            return str;
        }
    }
    static class GetValue
    {
        public static int GetIntValue(string comment)
        {
            int intVal;
            do Console.Write(comment);
            while (!int.TryParse(Console.ReadLine(), out intVal));
            return intVal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = GetValue.GetIntValue("Введите N:");
            UserString userString = new UserString(N, '0', '9');
            Console.WriteLine(userString);
            userString.MoveOff("02468");
            Console.WriteLine(userString);
        }
    }
}
