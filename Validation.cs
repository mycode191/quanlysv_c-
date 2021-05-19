using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class Validation
    {
        public String CheckString()
        {
            while (true)
            {
                String input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Can't be empty!");
                    Console.WriteLine("Enter again: ");
                }
                else
                {
                    return input;
                }
            }
        }

        public bool checkInputYN()
        {
            while (true)
            {
                String result = CheckString();
                if (Equals(result.ToLower(), "y"))
                {
                    return true;
                }
                if (Equals(result.ToLower(), "n"))
                {
                    return false;
                }
                Console.WriteLine("Please enter y/Y or n/N!");
                Console.WriteLine("Enter again: ");
            }
        }
        public int CheckInt()
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You must input an integer!");
                    Console.Write("Enter again:");
                }
            }

        }
        public int CheckIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number < min || number > max)
                    {
                        Console.WriteLine("You must choose in range (0,5)!");
                        
                    }
                    return number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You must input an integer!");
                    Console.Write("Enter again:");
                }
            }

        }
        public DateTime CheckDate()
        {
            while (true)
            {
                try
                {
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    return date;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You must input date time yyyy-MM-dd!");
                    Console.Write("Enter again:");
                }
            }
        }
    }
}
