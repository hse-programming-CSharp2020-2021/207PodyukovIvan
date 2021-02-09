using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// Пассажир
    /// </summary>
    public class Passenger
    {
        string name;
        string lastName;
        int age;
        public bool IsOld { private set; get; }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get { return age; }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        int numberOfChildren;
        public bool IsNewBorn { private set; get; }
        public int NumberOfChildren
        {
            set
            {
                numberOfChildren = value;
            }
            get { return numberOfChildren; }
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn) priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }
        public void StartServingQueue()
        {
            if (priorityQueue.Count <= 3)
            {
                while (priorityQueue.Count > 0)
                {
                    Passenger p = priorityQueue.Dequeue();
                    Console.WriteLine("priority: " + p.Name + " " + p.LastName);
                }
                while (ordinaryQueue.Count > 0)
                {
                    Passenger p = ordinaryQueue.Dequeue();
                    Console.WriteLine("ordinary: " + p.Name + " " + p.LastName);
                }
            }
            else
            {
                while (priorityQueue.Count > 0 || ordinaryQueue.Count > 0)
                {
                    if (priorityQueue.Count > 0)
                    {
                        Passenger p = priorityQueue.Dequeue();
                        Console.WriteLine("priority: " + p.Name + " " + p.LastName);
                    }
                    if (ordinaryQueue.Count > 0)
                    {
                        Passenger p = ordinaryQueue.Dequeue();
                        Console.WriteLine("ordinary: " + p.Name + " " + p.LastName);
                    }
                }
            }
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Random rand = new Random();
            PassengerQueue queue = new PassengerQueue();
            int N = rand.Next(4, 20);
            for (int i = 0; i < N; i++)
            {
                int x = rand.Next(0, 3);
                if (x == 1)
                {
                    queue.AddToQueue(new PassengerWithChildren() { Name = rand.Next(1000, 9999).ToString(), LastName = rand.Next(10000, 99999).ToString(), Age = rand.Next(30, 90), NumberOfChildren = rand.Next(1, 5) });
                }
                else
                {
                    queue.AddToQueue(new Passenger() { Name = rand.Next(1000, 9999).ToString(), LastName = rand.Next(10000, 99999).ToString(), Age = rand.Next(30, 90) });
                }
                queue.StartServingQueue();
            }
        }
    }
}
