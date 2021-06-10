using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Товары #Goods[Code1;Code2;Code3]#";
            MatchCollection m = Regex.Matches(s, "#Goods\\[(.*?)\\]#");
            Random rand = new Random();
            foreach (Match x in m)
            {
                string[] arr = Regex.Split(x.Groups[1].Value, ";");
                foreach (string str in arr)
                {
                    Console.WriteLine("Товар " + str + " был продан за " + rand.Next(100, 1000000) + " рублей");
                }
            }
        }
    }
}
