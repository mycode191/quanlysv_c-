using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class VNStudent:Student
    {
        public string Identity { get; set; }

        public VNStudent()
        {

        }

        public VNStudent(int id, string name, DateTime dob, string identity) : base(id, name, dob)
        {
            this.Identity = identity;
        }

        public override string ToString()
        {
            return base.ToString() + " " + String.Format( "{0}", Identity);
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Input your identity number:");
            this.Identity = Console.ReadLine();
        }

    }
}
