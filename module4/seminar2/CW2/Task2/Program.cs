using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Runtime.Serialization;

namespace Task02_xml
{
    [DataContract]
    public class Human
    {
        [DataMember]
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
    }
    [DataContract]
    public class Professor : Human
    {
        public Professor()
        {

        }
        public Professor(string name) : base(name) { }
    }
    [DataContract]
    public class Dept
    {
        [DataMember]
        public string DeptName { get; set; }
        List<Human> staff;
        [DataMember]
        public List<Human> Staff { get { return staff; } set { staff = value; } }
        public Dept() { }
        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }
    [DataContract]
    public class University
    {
        public University() { }
        [DataMember]
        public string UniversityName { get; set; }
        [DataMember]
        public List<Dept> Departments { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            University HSE = new University();
            HSE.UniversityName = "NRU HSE";

            Human[] deptStaff = { new Professor("Ivanov"),
                      new Professor("Petrov")
                    };

            Dept SE = new Dept("SE", deptStaff);
            HSE.Departments = new List<Dept>();
            HSE.Departments.Add(SE);

            University MSU = new University();
            MSU.UniversityName = "MSU";

            Human[] deptStaffM = { new Professor("Ivanov"),  new Professor("Chizov"),
                      new Professor("Petrov")
                    };

            Dept SEM = new Dept("SEM", deptStaffM);
            MSU.Departments = new List<Dept>();
            MSU.Departments.Add(SEM);

            University[] universities = new University[] { HSE, MSU };
            string s = JsonSerializer.Serialize(universities);
            University[] deserial = JsonSerializer.Deserialize<University[]>(s);
            
            var ds = new DataContractSerializer(typeof(University[]), new Type[] {typeof(Professor)});
            using (FileStream fs = new FileStream("univer.xml", FileMode.OpenOrCreate))
            {
                ds.WriteObject(fs, universities);
            }
            using (FileStream fs = new FileStream("univer.xml", FileMode.Open))
            {
                University[] universities2 = (University[])ds.ReadObject(fs);
                foreach (Dept d in universities2[0].Departments)
                    foreach (Human h in d.Staff)
                    {
                        if (h is Professor)
                            Console.WriteLine(d.DeptName + " prof.: " + h.Name);
                    }

                foreach (Dept d in universities2[1].Departments)
                    foreach (Human h in d.Staff)
                    {
                        if (h is Professor)
                            Console.WriteLine(d.DeptName + " prof.: " + h.Name);
                    }
            }
            

        }
    }
}
      
