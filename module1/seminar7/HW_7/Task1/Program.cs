using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText("input.txt");
            string[] A = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool[] L = new bool[A.Length];
            int check = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (int.TryParse(A[i], out int a) && a >= -10 && a <= 10)
                {
                    if (a >= 0)
                    {
                        L[i] = true;
                    }
                    else
                    {
                        L[i] = false;
                    }
                }
                else
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                string s = "";
                for (int i = 0; i < L.Length; i++)
                {
                    s = s + L[i] + " ";
                }
                File.WriteAllText("output.txt", s);
                Console.WriteLine("Операция успешно выполнена!");
            }
            else
            {
                Console.WriteLine("В файле некорректные данные");
            }
        }
    }
}
