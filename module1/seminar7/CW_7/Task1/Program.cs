using System;
using System.IO;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(),out int a))
            {
                string s1 = "";
                while (a>0)
                {
                    s1 = s1 + a % 2;
                    a = a / 2;
                }
                string s = "";
                for (int i=s1.Length-1;i>=0;i--)
                {
                    s = s + s1[i];
                }    
                File.WriteAllText("IntNumber.txt", s);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
