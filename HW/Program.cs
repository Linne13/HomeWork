using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Student
    {
        public int age;
        public string name;
        public string address;

   
        public Student(string name, string address, int age)
        {
            this.age = age;
            this.address = address;
            this.name = name;
        }

        public override string ToString()
        {
            return age + " " + "years old;" + " " + "name:" + name + ";" + " " + "hometown: " + address;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student("Kurosaki", "Karakura", 17);
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
