using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    
    class Manager
    {
        public List<Student> list = new List<Student>();
        private Validation input = new Validation();
        public Manager()
        {
            list.Add(new Student(1, "hieu", new DateTime(2000,01,19)));
            list.Add(new ForeignStudent(2, "thuan", new DateTime(2001,09,08), "Japan"));
            list.Add(new VNStudent(3, "giang", new DateTime(2001,01,01), "54321"));
        }

        public void display()
        {
            Console.WriteLine("\n****** Student List ******");
            foreach(Student l in list)
            {
                Console.WriteLine(l.ToString());
            }
            Console.WriteLine("*****************\n");
        }

        public void InserList()
        {
            Console.WriteLine("Enter number of student you want to add: ");
            int num = input.CheckInt();
            for(int i = 0; i < num; i++)
            {
                insert();
            }
        }

        public void search()
        {
    
            Console.WriteLine("Enter student id");
            int id = input.CheckInt();
            int count = 0; 
            foreach(Student l in list){
                if((l.id) == id)
                {
                    Console.WriteLine("Found!");
                    Console.WriteLine(l.ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Not found student with id "+ id +" in the list!");
            }
        }

        public Student CheckId(int type)
        {
            Student s = new Student();
            if(type == 1)
            {
                s.Input();
                foreach (Student l in list)
                {
                    if (l.id == s.id)
                    {
                        Console.WriteLine("Contain id in student list, please input again");
                        s.Input();
                    }
                }
            }
            else if(type == 2)
            {
                s = new ForeignStudent();
                s.Input();
                foreach (Student l in list)
                {
                    if (l.id == s.id)
                    {
                        Console.WriteLine("Contain id in student list, please input again");
                        s.Input();
                    }
                }
            }
            else if(type == 3)
            {
                s = new VNStudent();
                s.Input();
                foreach (Student l in list)
                {
                    if (l.id == s.id)
                    {
                        Console.WriteLine("Contain id in student list, please input again");
                        s.Input();
                    }
                }
            }
            return s;
        }
        public void insert()
        {
           
            Console.WriteLine("1 for student");
            Console.WriteLine("2 for fstudent");
            Console.WriteLine("3 for vnstudent");
            int choice = input.CheckIntLimit(1, 3);
            switch (choice)
            {
                case 1:
                    list.Add(CheckId(1));
                    display();
                    break;
                case 2:
                    list.Add(CheckId(2));
                    display();
                    break;
                case 3:
                    list.Add(CheckId(3));
                    display();
                    break;
                default:
                    break;
            }
        }
        public void remove()
        {
            int count = 0;
            display();
            Console.WriteLine("Enter student id you want to remove:");
            int id = input.CheckInt();
            Console.WriteLine("Are you sure to delete?");
            if (input.checkInputYN())
            {
                foreach (Student l in list)
                {
                    if ((l.id) == id)
                    {
                        count++;
                        list.Remove(l);
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Can't remove student with id = " + id);
                }
                Console.WriteLine("Student list after remove");

                display();
            }
            else
            {
                display();
            }
        }

        public void sort()
        {
            Console.WriteLine("Choose how to sort");
            Console.WriteLine("1.sort by id");
            Console.WriteLine("2. sort by name");
            Console.WriteLine("3. sort by dob");
            int choice = input.CheckIntLimit(1, 3);
            switch (choice)
            {
                case 1:
                    list.Sort((a, b) => a.id.CompareTo(b.id));
                    display();
                    break;
                case 2:
                    list.Sort((a, b) => a.name.CompareTo(b.name));
                    display();
                    break;
                case 3:
                    list.Sort((a, b) => a.dob.CompareTo(b.dob));
                    display();
                    break;
            }
        }
    }
}
