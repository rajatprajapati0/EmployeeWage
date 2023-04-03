using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int present = 1; 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            Random rnd = new Random();

            int check=rnd.Next(0,2); 
            if (check==present) 
            {
                Console.WriteLine("Employee is present");
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
