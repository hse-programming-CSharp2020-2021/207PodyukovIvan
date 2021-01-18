using System;

namespace Task3
{
    class StaticTempConverters
    {
        public static double ConvertToKelvin(double x)
        {
            return x + 273.15;
        }
        public static double ConvertFromKelvin(double x)
        {
            return x - 273.15;
        }
        public static double ConvertToRankin(double x)
        {
            return (x + 273.15) * (9.0 / 5);
        }
        public static double ConvertFromRankin(double x)
        {
            return (x - 491.67) * (5.0 / 9);
        }
        public static double ConvertToReaumur(double x)
        {
            return x * (4.0 / 5);
        }
        public static double ConvertFromReaumur(double x)
        {
            return x * (5.0 / 4);
        }
    }
    class TemperatureConverterImp
    {
        public double ConvertFromFahrenheit(double x)
        {
            return (5.0 / 9) * (x - 32);
        }
        public double ConvertToFahrenheit(double x)
        {
            return (9.0 / 5) * x + 32;
        }
    }
    class Program
    {
        delegate double delegateConvertTemperature(double x);
        static void Main(string[] args)
        {
            TemperatureConverterImp tci = new TemperatureConverterImp();
            delegateConvertTemperature[] delegates = new delegateConvertTemperature[4];
            delegates[0] = tci.ConvertToFahrenheit;
            delegates[1] = StaticTempConverters.ConvertToKelvin;
            delegates[2] = StaticTempConverters.ConvertToRankin;
            delegates[3] = StaticTempConverters.ConvertToReaumur;
            do
            {
                Console.Clear();
                double x;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Введите температуру в градусах Цельсия:");
                } while (!double.TryParse(Console.ReadLine(), out x));
                Console.WriteLine("°C\t°F\tK\t°R\t°Re");
                Console.WriteLine(x + "\t" + delegates[0](x).ToString("F2") + "\t" + delegates[1](x).ToString("F2") + "\t" + delegates[2](x).ToString("F2") + "\t" + delegates[3](x).ToString("F2"));
                Console.WriteLine("Чтобы выйти из программы, нажмите Escape");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
