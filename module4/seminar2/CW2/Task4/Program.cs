using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization;

namespace Task4
{
    [Serializable, DataContract]
    public struct ConsoleSymbolStruct
    {       
        [DataMember]
        public char Simb
        {
            get;set;
        }
        [DataMember]
        public int Y
        {
            get;set;
        }
        [DataMember]
        public int X
        {
            get;set;
        }
        public ConsoleSymbolStruct(int x, int y, char simb)
        {
            X = x;
           Y = y;
            Simb = simb;
        }
        public override string ToString()
        {
            return $"simb = {Simb}. x = {X}. x = {Y}.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ConsoleSymbolStruct[] simbols = new ConsoleSymbolStruct[rand.Next(3, 10)];
            for (int i = 0; i < simbols.Length; i++)
            {
                simbols[i] = new ConsoleSymbolStruct(rand.Next(-20, 21), rand.Next(-20, 21), (char)rand.Next(33, 127));
            }
            Console.WriteLine("Изначальный массив:");
            Array.ForEach(simbols, (x) => Console.WriteLine(x));
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, simbols);
            }
            using (FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                ConsoleSymbolStruct[] newSimbols=(ConsoleSymbolStruct[])bf.Deserialize(fs);
                Console.WriteLine("Бинарная десериализация:");
                Array.ForEach(newSimbols, (x) => Console.WriteLine(x));
            }
            XmlSerializer x = new XmlSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream fs = new FileStream("2.xml", FileMode.OpenOrCreate))
            {
                x.Serialize(fs, simbols);
            }
            using (FileStream fs = new FileStream("2.xml", FileMode.OpenOrCreate))
            {
                ConsoleSymbolStruct[] newSimbols = (ConsoleSymbolStruct[])x.Deserialize(fs);
                Console.WriteLine("Xml-десериализация:");
                Array.ForEach(newSimbols, (x) => Console.WriteLine(x));
            }
            string json = JsonSerializer.Serialize(simbols);
            ConsoleSymbolStruct[] jsonSymbols = JsonSerializer.Deserialize<ConsoleSymbolStruct[]>(json);
            Console.WriteLine("Json-десериализация:");
            Array.ForEach(jsonSymbols, (x) => Console.WriteLine(x));
            var ds = new DataContractSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream fs = new FileStream("3.xml", FileMode.OpenOrCreate))
            {
                ds.WriteObject(fs, simbols);
            }
            using (FileStream fs = new FileStream("3.xml", FileMode.OpenOrCreate))
            {
                ConsoleSymbolStruct[] newSimbols = (ConsoleSymbolStruct[])ds.ReadObject(fs);
                Console.WriteLine("DataContract-десериализация:");
                Array.ForEach(newSimbols, (x) => Console.WriteLine(x));
            }
        }
    }
}
