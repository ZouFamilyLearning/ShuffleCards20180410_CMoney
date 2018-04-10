using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("ID:{0}, Name:{1}", ID, Name);
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student jojo = new Student(1, "jojo");
            Console.Write(jojo.ToString());
        }
    }
}
