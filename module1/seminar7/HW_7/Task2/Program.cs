using System;
using System.IO;

namespace Task2
{
    
    class Program
    {
        public static int F(int x)
        {
            int a = 1;
            while (a < x)
            {
                a *= 2;
            }
            return a / 2;
        }
        static void Main(string[] args)
        {
            string str = File.ReadAllText("input.txt");
            string[] A = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] B = new int[A.Length];
            int check = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (int.TryParse(A[i], out int a) && a >= 0 && a <= 10000)
                {
                    B[i] = F(a);
                }
                else
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                string s = "";
                for (int i = 0; i < B.Length; i++)
                {
                    s = s + B[i] + " ";
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
