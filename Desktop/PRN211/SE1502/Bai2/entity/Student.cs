using System;
using System.Diagnostics.CodeAnalysis;

namespace Bai2
{
     public class Student 
    {  
        public int id { set; get; }
        public string name { set; get; }
        public DateTime dob { set; get; }

        public Student()
        {
        }

        public Student(int id, string name, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public override string ToString()
        {
            return id + " " + name + " " + dob;
        }

        public override bool Equals(object obj)
        {
            Student s = obj as Student;
            return this.id.Equals(s.id);
        }

        public void Input()
        {
            Validation input = new Validation();
            Console.WriteLine("Input id:");
            this.id = input.CheckInt();
            Console.WriteLine("Input name");
            this.name = Console.ReadLine();
            Console.WriteLine("Input dob");
            this.dob = input.CheckDate();
        }

     
    }
}
