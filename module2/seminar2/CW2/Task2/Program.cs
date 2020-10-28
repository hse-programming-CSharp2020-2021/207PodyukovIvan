using System;

namespace Task2
{
    class LatinChar
    {
        char _char = 'a';
        public char Char
        {
            get
            {
                return _char;
            }
            set
            {
                if (!(value >= 'a' && value <= 'z' || value >= 'A' && value <= 'Z'))
                    throw new ArgumentException("В качестве символа должна быть латинская буква");
                _char = value;
            }
        }
        public LatinChar(char ch)
        {
            Char = ch;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (char.TryParse(Console.ReadLine(), out char minChar) && char.TryParse(Console.ReadLine(), out char maxChar) && minChar < maxChar)
            {
                for (int i = minChar; i < maxChar; i++)
                {
                    LatinChar latin = new LatinChar((char)i);
                    Console.WriteLine(latin.Char);
                }
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
