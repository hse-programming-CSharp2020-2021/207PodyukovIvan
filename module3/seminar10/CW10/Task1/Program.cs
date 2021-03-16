// Проект 2. Чтение целых из двоичного потока. 
// ЧИТАТЬ И ЗАПИСЫВАТЬ СТРОГО ПО ОДНОМУ ЧИСЛУ!!! 
using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {    
        FileStream f = new FileStream("../../../t.dat", FileMode.Open);
        BinaryReader fIn = new BinaryReader(f);
        long n = f.Length / 4; int a;
        // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
        Console.WriteLine("\nЧисла в обратном порядке:");
        string s = "";
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            s = s + a + " ";
        }
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        StringBuilder sb = new StringBuilder("");
        sb.Append(arr);
        Console.WriteLine(sb.ToString());
        // 2) TODO: увеличить  все числа в файле в 5 раз
        f.Seek(0, SeekOrigin.Begin);
        BinaryWriter fOut = new BinaryWriter(f);
        for (int i = 0; i < n; i++)
        {
            a = 5 * fIn.ReadInt32();
            f.Position -= 4;
            fOut.Write(a);
        }
        // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
        Console.WriteLine("Числа в прямом порядке");
        f.Seek(0, SeekOrigin.Begin);
        for (int i = 0; i < n; i++)
        {
            a = fIn.ReadInt32();
            Console.Write(a + " ");
        }
        fIn.Close();
        f.Close();
    }
}
