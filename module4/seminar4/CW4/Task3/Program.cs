using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    class RandomCollection : IEnumerable
    {
        public static int n;
        static Random rand = new Random();

        public IEnumerator GetEnumerator()
        {
            return new RandomEnumerator();
        }
        private class RandomEnumerator : IEnumerator
        {
            int position = -1;
            public object Current
            {
                get
                {
                    if (position == -1 || position >= n)
                        throw new InvalidOperationException();
                    return rand.Next();
                }
            }

            public bool MoveNext()
            {
                if (position < n - 1)
                {
                    position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            RandomCollection rc = new RandomCollection();
            RandomCollection.n = 6;
            foreach(int a in rc)
            {
                Console.WriteLine(a);
            }
        }
    }
}
