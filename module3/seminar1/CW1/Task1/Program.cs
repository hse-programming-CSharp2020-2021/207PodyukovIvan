using System;

namespace Task1
{
    class Program
    {
        delegate int Cast(double a);
        static void Main(string[] args)
        {
            Cast cast1 = delegate (double x) { return (int)x; };
            Cast cast2 = delegate (double x) { return (int)Math.Log10(x) + 1; };
            Console.WriteLine(cast1(4.6));
            Console.WriteLine(cast2(4.6));
            Cast cast3 = cast1;
            cast3 += cast2;            
            Console.WriteLine(cast3(4.6));
            Cast cast4 = x => (int)x;
            Cast cast5 = x => (int)Math.Log10(x) + 1;
            Console.WriteLine(cast4(4.6));
            Console.WriteLine(cast5(4.6));
        }
    }
}
