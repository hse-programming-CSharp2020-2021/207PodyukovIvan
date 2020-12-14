using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    static class Methods
    {
        public static bool Validate(string str)
        {
            str = str.ToLower();
            char[] english = new char[27];
            english[0] = ' ';
            for (int i = 1; i < english.Length; i++)
            {
                english[i] = (char)('a' + i);
            }
            if (str.IndexOfAny(english) < 0) return false;
            return true;
        }
        public static string[] ValidatedSplit(string str, char ch)
        {
            string[] output = null;
            output = str.Split(ch);
            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }
            return output;
        } 
        public static string Shorten(string str)
        {
            str = str.ToLower();
            char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y' };
            int ind = str.IndexOfAny(alph);
            return str.Substring(0, ind + 1);
        }
        public static string Abbrevation(string str)
        {
            string output = String.Empty;
            if (str != String.Empty)
            {
                string[] tmp = str.Split(' ');
                foreach (string s in tmp)
                {
                    if (s == "")
                        continue;
                    string shortenS = Shorten(s);
                    FirstUpcase(ref shortenS);
                    output += shortenS;
                }
            }
            return output;
        }
        public static void FirstUpcase(ref string str)
        {
            char[] chars = str.ToCharArray();
            str = str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        }

    }
}
