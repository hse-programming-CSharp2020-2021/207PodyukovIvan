using System;
using System.IO;
using System.Text;

namespace Task3
{
    class Program
    {
        static char[] chars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("../../../Program.cs", FileMode.Open))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes);
                string text = Encoding.Default.GetString(bytes);
                Console.WriteLine(text);
                for (int i = 0; i < text.Length; i++)
                {
                    if (Array.IndexOf(chars, text[i]) >= 0)
                    {
                        Console.WriteLine(text[i]);
                    }
                }
            }
        }
    }
}
