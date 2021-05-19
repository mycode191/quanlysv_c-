using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class ForeignStudent:Student
    {
        public String country { get; set; }

        public ForeignStudent()
        {
        }

        public ForeignStudent(int id, string name, DateTime dob, string country) : base(id, name, dob)
        {
            this.country = country;
        }

        public override string ToString()
        {
            return base.ToString() + " " + country;
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Input your country:");
            this.country = Console.ReadLine();
            
        }
    }
}
