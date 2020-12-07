using System;
public abstract class MyStrings
{
    protected string str;
    protected static Random rnd = new Random();
    abstract public void Validate();
    /// <summary>
    /// Свойство, возвращающее информацию о палиндромности
    /// </summary>
    public bool IsPalindrome
    {
        get
        {
            if (str.Length > 0)
            {
                char[] tmp = str.ToCharArray();
                Array.Reverse(tmp);
                string tmpString = new string(tmp);
                if (str.CompareTo(tmpString) == 0) return true;
            }
            return false;
        }
    }
    public int CountLetter(char letter)
    {
        int start = 0, result = -1, res;
        do
        {
            res = str.IndexOf(letter, start);
            start = res + 1;    // начало следующего поиска 
            result++;           // счетчик вхождений
        } while (res >= 0);
        return result;
    }
    public override string ToString()
    {
        return str;
    }
}
public class RusString:MyStrings
{
    public override void Validate()
    {
        foreach (char ch in str)
        {
            if (!(ch >= 'а' && ch <= 'я'))
            {
                throw new ArgumentOutOfRangeException();
            }    
        }
    }
    public RusString(char start, char finish, int n)
    {
        // проверяем количество символов строки и допустимые границы
        if (n <= 0 || start < 'а' || finish > 'я')
            throw new ArgumentOutOfRangeException();
        char[] letters = new char[n];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)rnd.Next(start, finish + 1);
        }
        str = new String(letters);
        Validate();
    }
}
public class LatString:MyStrings
{
    public override void Validate()
    {
        foreach (char ch in str)
        {
            if (!(ch >= 'a' && ch <= 'z'))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    public LatString(char start, char finish, int n)
    {
        // проверяем количество символов строки и допустимые границы
        if (n <= 0 || start < 'a' || finish > 'z')
            throw new ArgumentOutOfRangeException();
        char[] letters = new char[n];
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)rnd.Next(start, finish + 1);
        }
        str = new String(letters);
        Validate();
    }
}
class Program
{
    static void Main(string[] args)
    {
        char start = 'к', finish = 'ю';
        do
        {
            MyStrings testString = new RusString(start, finish, 10);
            MyStrings testString1 = new LatString('d', 'x', 7);
            Console.WriteLine(testString);
            Console.WriteLine(testString.CountLetter('о'));
            Console.WriteLine(testString1);
            Console.WriteLine(testString1.CountLetter('j'));
            // тестируем неверные входные данные
            try
            {
                testString = new RusString(start, finish, -11);              
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
            }
            try
            {
                testString1 = new LatString('6', 'x', 6);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
            }
            Console.WriteLine(testString);
            Console.WriteLine(testString.CountLetter('о'));
            Console.WriteLine(testString1);
            Console.WriteLine(testString1.CountLetter('j'));
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}


