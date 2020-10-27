using System; // Для доступа к классу Console
using System.Collections.Generic;
using System.IO; // Для работы с файлами и директориями

namespace Directories
{​​​​​​​

    class Program
    {​​​​​​​

        static void DirectoryOverview(string path)
        {
            List<string> list = new List<string>();
            DirectoryInfo dirinf = new DirectoryInfo(path);
            FileInfo[] fi = dirinf.GetFiles();
            DateTime dt = dirinf.CreationTime;
            Console.WriteLine(dirinf);
            Console.WriteLine(dt);
            Console.WriteLine(fi);
        }

        static void Main(string[] args)
        {​​​​​​​

       // Блок try-catch при работе с файлами обязателен!

            try
            {
                DirectoryOverview(@"..\..\..\");
            }
            catch (Exception ex) {​​​​​​​

                Console.WriteLine(ex.Message);

            }​​​​​​​

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти");

            Console.ReadLine();

            }​​​​

    }​​

}​​​​​​​
