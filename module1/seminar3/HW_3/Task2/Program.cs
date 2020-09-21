using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            if (int.TryParse(Console.ReadLine(),out a))
            {
                string s = a.ToString();
                int b = 0;
                for (int i=s.Length-1;i>=0;i--)
                {
                    b = b + Convert.ToInt32(s[i].ToString()) * (int)Math.Pow(10, i);
                }
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
