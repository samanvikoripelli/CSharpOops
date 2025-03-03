using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class student : Person
    {
        private int rollNo;

        public student(string name, int age, int rollNo) : base(name, age)
        {
            this.rollNo = rollNo;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Student Name: {name}, Age: {age}, Roll No: {rollNo}");
        }
    }

    class Teacher : Person
    {
        private string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Name: {name}, Age: {age}, Subject: {subject}");
        }
    }
}