using System;

namespace Task4
{
    class Robot
    {
        public char[,] Field { get; set; }
        // класс для представления робота
        int x, y; // положение робота на плоскости 

        public void Right() { Field[x, y] = '+'; x++; Field[x, y] = '*'; }      // направо
        public void Left() { Field[x, y] = '+'; x--; Field[x, y] = '*'; }     // налево
        public void Forward() { Field[x, y] = '+'; y++; Field[x, y] = '*'; }  // вперед
        public void Backward() { Field[x, y] = '+'; y--; Field[x, y] = '*'; }   // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }
    delegate void Steps();
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot();    // конкретный робот 
            Steps delR = new Steps(rob.Right);      // направо
            Steps delL = new Steps(rob.Left);       // налево
            Steps delF = new Steps(rob.Forward);    // вперед
            Steps delB = new Steps(rob.Backward);   // назад
            int x, y;
            string str;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите ограничения координат на поле(x и y) через пробел:");
                str = Console.ReadLine();
                if (str.Split(' ').Length < 2)
                {
                    str = str + " 2k 5r";
                }
            } while (!(int.TryParse(str.Split(' ')[0], out x) && (int.TryParse(str.Split(' ')[1], out y) && x > 0 && y > 0)));
            rob.Field = new char[x, y];
            string startPosition = rob.Position();
            Console.WriteLine(startPosition); // Стартовая позиция.
            string s = Console.ReadLine();
            Steps del = null;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                {
                    del += delR;
                }
                else if (s[i] == 'L')
                {
                    del += delL;
                }
                else if (s[i] == 'F')
                {
                    del += delF;
                }
                else if (s[i] == 'B')
                {
                    del += delB;
                }
            }

            try
            {
                del();
                char[,] arr = rob.Field;
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[j, i] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(arr[j, i]);
                        if (arr[j, i] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(rob.Position());     // сообщить координаты
                Console.WriteLine("Для завершения нажмите любую клавишу.");
                Console.ReadKey();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Ошибка! Робот вышел за границы поля!");
            }

        }
    }
}
