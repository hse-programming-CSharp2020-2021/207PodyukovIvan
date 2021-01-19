using System;
using System.Text;

namespace Task1
{
    delegate string ConvertRule(string s);
    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
    class Program
    {
        public static string RemoveDigits(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= '0' && str[i] <= '9'))
                {
                    result = result + str[i];
                }
            }
            return result;
        }
        public static string RemoveSpaces(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    result = result + str[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] arr = new string[] { "sjjdjj23344", "jdjd dhdhh sss       d", "h3hjhj  3   4  4 4 5hghgh" };
            Converter conv = new Converter();
            ConvertRule cr1 = RemoveDigits;
            ConvertRule cr2 = RemoveSpaces;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(conv.Convert(arr[i], cr1));
                Console.WriteLine(conv.Convert(arr[i], cr2));
            }
            ConvertRule cr = cr1 + cr2;
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(conv.Convert(arr[i], cr));
            }
        }
    }
}
