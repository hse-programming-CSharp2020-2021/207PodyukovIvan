﻿using System;
using System.Collections.Generic;

namespace Task4
{
    namespace A
    {
        class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
            }
            public override string ToString()
            {
                return $"{Data}";
            }
        }

        class LinkedList
        {
            Node head;
            Node tail;

            public int Count { get; set; }

            public void Add(int data)
            {
                Node node = new Node(data);
                if (head == null)
                    head = node;
                else
                    tail.Next = node;
                tail = node;
                Count++;
            }
            public void AddFirst(int data)
            {
                Node node = new Node(data);

                node.Next = head;
                head = node;

                if (Count == 0)
                    tail = head;

                Count++;
            }
            public void Clear()
            {
                Count = 0;
                head = null;
                tail = null;
            }
            public bool Contains(int data)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data == data)
                        return true;
                    current = current.Next;
                }
                return false;
            }
            public void Print()
            {
                Node current = head;
                int i = 1;
                while (current != null)
                {
                    Console.WriteLine($"{i} - {current}");
                    current = current.Next;
                    i++;
                }
            }

            public Node Max()
            {
                Node current = head;
                Node max = null;
                if (head != null)
                {
                    while (current != null)
                    {
                        current = current.Next;
                        if (current.Data > max.Data)
                        {
                            max = current;
                        }
                    }
                }
                return max;
            }

            public Node Min()
            {
                Node current = head;
                Node min = null;
                if (head != null)
                {
                    while (current != null)
                    {
                        current = current.Next;
                        if (current.Data < min.Data)
                        {
                            min = current;
                        }
                    }
                }
                return min;
            }

            public Node Middle()
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == Count / 2)
                    {
                        break;
                    }
                    i++;
                    current = current.Next;
                }
                return current;
            }

            public bool Remove(int data)
            {
                Node current = head;
                Node lastCurrent = null;
                if (head != null)
                {
                    while (current != null)
                    {
                        if (current.Data == data)
                        {
                            if (lastCurrent != null && current.Next != null)
                            {
                                lastCurrent.Next = current.Next;
                            }
                            if (lastCurrent != null && current.Next == null)
                            {
                                lastCurrent.Next = null;
                            }
                            return true;
                        }
                        lastCurrent = current;
                        current = current.Next;
                    }
                }
                return false;
            }
        }

        class MainClass
        {
            public static void Main()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Add(1);
                linkedList.Add(2);
                linkedList.AddFirst(3);
                linkedList.Add(4);
                linkedList.Print();
                linkedList.Remove(2);
                linkedList.Print();
            }
        }
    }
}
