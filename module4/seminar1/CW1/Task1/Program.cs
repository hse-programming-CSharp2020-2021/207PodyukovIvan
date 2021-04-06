using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task1
{
    [Serializable]
    class Student
    {
        string surname;
        int course;
        public Student(string surname, int course)
        {
            this.surname = surname;
            this.course = course;
        }
        public override string ToString()
        {
            return $"Surname: {surname}. Course: {course}";
        }
    }
    [Serializable]
    class Group
    {
        string name;
        List<Student> students;
        public Group(string name, List<Student> students)
        {
            this.name = name;
            this.students = students;
        }
        public override string ToString()
        {
            string s = $"Group name: {name}. Count of students = {students.Count}. Students:\n";
            for (int i = 0; i < students.Count; i++)
            {
                s = s + students[i] + "\n";
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список студентов:");
            Random rand = new Random();
            int n = rand.Next(3, 11);
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student(rand.Next(1000, 10000).ToString(), rand.Next(1, 5));
            }
            Array.ForEach(students, (x) => Console.WriteLine(x));
            Console.WriteLine("Восстановленные студенты:");
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("students.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, students);
            }

            using (FileStream fs = new FileStream("students.txt", FileMode.OpenOrCreate))
            {
                Student[] newStudents = (Student[])bf.Deserialize(fs);
                Array.ForEach(newStudents, (x) => Console.WriteLine(x));
            }
            Group group1 = new Group("group1", students.ToList());
            List<Student> list = new List<Student>();
            int m = rand.Next(2, 7);
            for (int i = 0; i < m; i++)
            {
                list.Add(new Student(rand.Next(1000, 10000).ToString(), rand.Next(1, 5)));
            }
            Group group2 = new Group("group2", list);
            Console.WriteLine("Список групп");
            Console.WriteLine(group1);
            Console.WriteLine(group2);
            using (FileStream fs = new FileStream("group.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, new Group[] { group1, group2 });
            }
            using (FileStream fs = new FileStream("group.txt", FileMode.OpenOrCreate))
            {
                Group[] newGroups = (Group[])bf.Deserialize(fs);
                Console.WriteLine("Восстановленные группы:");
                Array.ForEach(newGroups, (x) => Console.WriteLine(x));
            }
        }
    }
}

