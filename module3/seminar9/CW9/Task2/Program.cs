using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            List<string> list = new List<string>();
            Array.ForEach(arr, (x) => list.Add(x.ToString()));
            File.WriteAllLines("file.txt", list.ToArray());
            using (StreamWriter sw = new StreamWriter(File.Open("streamwriter.txt", FileMode.OpenOrCreate)))
            {
                foreach (string s in list)
                {
                    sw.WriteLine(s);
                }
            }
            using (FileStream fs = new FileStream("filestream.txt", FileMode.OpenOrCreate))
            {
                string s = "";
                for (int i = 0; i < list.Count;i++)
                {
                    s = s + list[i] + "\n";
                }
                byte[] bytes = Encoding.Default.GetBytes(s);
                fs.Write(bytes, 0, bytes.Length);
            }
            using (BinaryWriter bw = new BinaryWriter(File.Open("binarywriter.txt", FileMode.OpenOrCreate)))
            {
                foreach (string s in list)
                {
                    bw.Write(s);
                }
            }
           using (StreamReader sr = new StreamReader(File.Open("file.txt",FileMode.Open)))
            {
                int sum = 0;
                int a;
                string text = String.Empty;
                do
                {
                    a = 0;
                    text = sr.ReadLine();
                    int.TryParse(text, out a);
                    if (a % 2 == 0)
                    {
                        sum = sum + a;
                    }
                } while (text != null);
                Console.WriteLine(sum);
            }
        }
    }
}
