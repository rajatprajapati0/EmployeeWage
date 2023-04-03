using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int wagePerHour = 20;
        const int present = 1; 
      
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            Random rnd = new Random();
            int check=rnd.Next(0,2);
            int perDayhour = 0;

            if (check==present) 
            {
                perDayhour = 8;
            }
            else 
            {
              perDayhour =0;    
            }
            int dailyWage = perDayhour * wagePerHour;
            Console.WriteLine($"Employee Per Day Wage :{dailyWage}");

        }
    }
}
