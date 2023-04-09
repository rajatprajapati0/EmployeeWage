using System;

namespace EmployeeWage
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            EmpWage emp = new EmpWage();
            emp.computeEmployeeWage();
            
        }
    }
}
