using System;
using System.Collections.Generic;

namespace Task2
{
    struct Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name = {Name}. Surname = {Surname}. Age = {Age}";
        }
    }
    class ElectronicQueue<T>
    {
        Queue<T> queue = new Queue<T>();
        public T Peek()
        {
            return queue.Peek();
        }
        public T Dequeue()
        {
            return queue.Dequeue();
        }
        public void Enqueue(T t)
        {
            queue.Enqueue(t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicQueue<Person> queueOfPersons = new ElectronicQueue<Person>();
            string[] names = new string[] { "jdjf", "fjjfjf", "JSjd" };
            string[] surnames = new string[] { "Jffdjf", "fjFFFjfjf", "JSjFFFd" };
            int[] ages = new int[] { 24, 53, 23 };
            for (int i = 0; i < names.Length; i++)
            {
                queueOfPersons.Enqueue(new Person(names[i], surnames[i], ages[i]));
            }
            Person p = queueOfPersons.Peek();
            Console.WriteLine(p);
        }
    }
}
