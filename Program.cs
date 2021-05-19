using System;
using System.Collections;
using System.Collections.Generic;

namespace Bai2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Validation input = new Validation();
            Manager m = new Manager();
            while (true)
            {
            Console.WriteLine("1. Add a list of students");
            Console.WriteLine("2. Find a student");
            Console.WriteLine("3. Add new student");
            Console.WriteLine("4. Remove a student");
            Console.WriteLine("5. Sort student list");
            Console.WriteLine("0. Exit program");
                int choose = input.CheckIntLimit(0, 5);
            switch (choose)
            {
                case 1:
                    m.InserList();
                    break;
     
                case 2:
                    m.search();
                    break;
          
                case 3:
                    m.insert();
                    break;
              
                case 4:
                    m.remove();
                    break;
                
                case 5:
                    m.sort();
                    break;
                 
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
                }
            }
        }
    }
}
