using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";

            // Создаем файл с данными
            if (!File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                string createText = "";
                Random rand = new Random();
                for (int i = 0; i < 10; i++)
                {
                    createText = createText + rand.Next(10, 100) + " ";
                }
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                int count = 0;
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                    if (i % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine();
                int[] even = new int[count];
                int[] odd = new int[arr.Length - count];
                int ev = 0;
                int od = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        even[ev] = i;
                        ev++;
                    }
                    else
                    {
                        odd[od] = i;
                        arr[i] = 0;
                        od++;
                    }
                }
                // вывод изменённого массива
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                // вывод массива индексов чётных значений
                foreach (int i in even)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                // вывод массива индексов нечётных значений
                foreach (int i in odd)
                {
                    Console.Write(i + " ");
                }
                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                // TODO3: Заменяем все нечётные числа исходного массива нулями
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}

