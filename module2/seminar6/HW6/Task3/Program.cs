using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Alexey", "Ivan", "Dmitry", "Vladimir", "Oleg", "Andrey", "Maxim", "Victor", "Alexandr", "Vyacheslav" };
            Random rand = new Random();
            Employee[] employees = new Employee[10];
            decimal[] arr = new decimal[10];
            for (int i = 0; i < employees.Length; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    employees[i] = new SalesEmployee(names[rand.Next(0, names.Count)], (decimal)(rand.Next(10, 30) + rand.NextDouble()), (decimal)(rand.Next(10, 30) + rand.NextDouble()));
                    names.Remove(employees[i].name);
                }
                else
                {
                    employees[i] = new PartTimeEmployee(names[rand.Next(0, names.Count)], (decimal)(rand.Next(10, 30) + rand.NextDouble()), rand.Next(10, 30));
                    names.Remove(employees[i].name);
                }
                arr[i] = employees[i].CalculatePay();
            }
            Array.Sort(arr, employees);
            Console.WriteLine("SaleEmployee:");
            for (int i = employees.Length - 1; i >= 0; i--)
            {
                if (employees[i] is SalesEmployee)
                {
                    Console.WriteLine(employees[i].name + " " + employees[i].CalculatePay().ToString("f3"));
                }
            }
            Console.WriteLine("PartTimeEmployee:");
            for (int i = employees.Length - 1; i >= 0; i--)
            {
                if (employees[i] is PartTimeEmployee)
                {
                    Console.WriteLine(employees[i].name + " " + employees[i].CalculatePay().ToString("f3"));
                }
            }
        }
    }
}
