using System;

namespace Task1
{
    class A
    {
        public virtual void getA()
        {
            Console.WriteLine("1");
        }
    }
    class B : A
    {
        public override void getA()
        {
            Console.WriteLine("2");
        }
    }
    class Program
    {
        static void Main()
        {
            A[] arr = new A[10];
            Random ran = new Random();
            for (int k = 0; k < arr.Length; k++)
                if (ran.Next(0, 3) % 2 == 0) arr[k] = new A();
                else arr[k] = new B();
            foreach (A d in arr) d.getA();
            Console.WriteLine("\nОбъекты класса B: ");
            foreach (A d in arr)
                if (d is B) d.getA();
            Console.WriteLine("\nОбъекты класса A: ");
            foreach (A d in arr)
                if (!(d is B)) d.getA();
            Console.WriteLine();
        }

    }
}
