using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Student
    {
        private string name;
        private int rollno;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Name is empty.");
            }
        }
        public int RollNo
        {
            get { return rollno; }
            set
            {
                if (value > 0)
                    rollno = value;
                else
                    Console.WriteLine("Roll number is negative.");
            }
        }

        public Student(string name, int rollno)
        {
            Name = name;
            RollNo = rollno;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Roll Number: {RollNo}");
        }
    }
}