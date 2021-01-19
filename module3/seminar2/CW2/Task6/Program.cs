using System;

namespace Task6
{
    class Plant
    {
        double growth;
        double photosensitivity;
        double frostresistance;
        public Plant(double g, double p, double f)
        {
            Growth = g;
            Photosensitivity = p;
            Frostresistance = f;
        }
        public double Growth
        {
            get
            {
                return growth;
            }
            set
            {
                growth = value;
            }
        }
        public double Photosensitivity
        {
            get
            {
                return photosensitivity;
            }
            set
            {
                photosensitivity = value;
            }
        }
        public double Frostresistance
        {
            get
            {
                return frostresistance;
            }
            set
            {
                frostresistance = value;
            }
        }
        public override string ToString()
        {
            return $"Growth = {growth:F3}. Photosensitivity = {photosensitivity:F3}. Frostresistance = {frostresistance:F3}";
        }
    }
    class Program
    {
        public static int Func(Plant x, Plant y)
        {
            if (y.Photosensitivity % 2 != 0 && x.Photosensitivity % 2 == 0)
            { 
                return 1; 
            } 
            else if (y.Photosensitivity % 2 == 0 && x.Photosensitivity % 2 == 0)
            {
                return 0;
            } 
            else 
            { 
                return -1; 
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                plants[i] = new Plant(rand.Next(25, 100) + rand.NextDouble(), rand.Next(0, 100) + rand.NextDouble(), rand.Next(0, 80) + rand.NextDouble());
            }
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(plants, delegate (Plant x, Plant y) { if (y.Growth > x.Growth) { return 1; } else if (y.Growth == x.Growth) { return 0; } else { return -1; } });
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(plants, (x, y) => { if (y.Frostresistance < x.Frostresistance) { return 1; } else if (y.Frostresistance == x.Frostresistance) { return 0; } else { return -1; } });
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.Sort(plants, Func);
            Array.ForEach(plants, Console.WriteLine);
            Console.WriteLine();
            Array.ConvertAll(plants, x => x.Frostresistance % 2 == 0 ? x.Frostresistance /= 3 : x.Frostresistance /= 2);
            Array.ForEach(plants, Console.WriteLine);
        }
    }
}
