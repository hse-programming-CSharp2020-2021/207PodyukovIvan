using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Task2
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Name = {Name}. Type = {GetType().Name}";
        }
    }
    [Serializable]
    public class Professor : Human
    {
        public Professor()
        {

        }
        public Professor(string name) : base(name) { }
    }
    [Serializable]
    public class Dept
    {
        public string DeptName { get; set; }
        public List<Human> Staff { get; set; }
        public Dept() { }
        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            Staff = new List<Human>(staffList);
        }
        public override string ToString()
        {
            string s = $"DeptName = {DeptName}. Staff:\n";
            for (int i = 0; i < Staff.Count; i++)
            {
                s = s + Staff[i] + "\n";
            }
            return s;
        }
    }
    [Serializable]
    public class University
    {
        public University()
        {

        }
        public string UniversityName { get; set; }
        public List<Dept> Departments { get; set; }
        public override string ToString()
        {
            string s = $"UniversityName = {UniversityName}. Departments:\n";
            for (int i = 0; i < Departments.Count; i++)
            {
                s = s + Departments[i] + "\n";
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Human[] humans1 = new Human[] { new Professor("Ivan"), new Professor("Andrey") };
            Human[] humans2 = new Human[] { new Professor("Alexey"), new Professor("Viktor"), new Professor("Evgeny") };
            Dept dept1 = new Dept("Dept1", humans1);
            Dept dept2 = new Dept("Dept2", humans2);
            university.UniversityName = "HSE";
            university.Departments = new List<Dept>() { dept1, dept2 };
            XmlSerializer xs = new XmlSerializer(typeof(University), new Type[] { typeof(Human), typeof(Professor), typeof(Dept) });
            using (FileStream fs = new FileStream("university.xml", FileMode.OpenOrCreate))
            {
                xs.Serialize(fs, university);
            }
            University newUniver;
            using (FileStream fs = new FileStream("university.xml", FileMode.Open))
            {
                newUniver = (University)xs.Deserialize(fs);
            }
            Console.WriteLine("Университет:");
            Console.WriteLine(university);
            Console.WriteLine("Восстановленный университет:");
            Console.WriteLine(newUniver);
        }
    }
}
