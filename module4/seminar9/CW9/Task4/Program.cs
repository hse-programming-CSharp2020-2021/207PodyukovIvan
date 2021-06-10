using System;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "e2-c4 вот это ход а не B2-C7";
            MatchCollection m = Regex.Matches(s, @"[a-h][1-8]-[a-h][1-8]", RegexOptions.IgnoreCase);
            for (int i = 0; i < m.Count; i++)
            {
                Console.WriteLine(m[i].Value);
            }
        }
    }
}
