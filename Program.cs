using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int wagePerHour = 20;
        const int maxWorkingDay = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            Random rnd = new Random();         
            int perDayhour = 0;
            int totalMonthlyWage = 0;

            for (int i = 0; i < maxWorkingDay; i++) 
            {
                int check = rnd.Next(0, 3);
                switch (check)
                {
                    case 0:
                        perDayhour = 0;
                        break;
                    case 1:
                        perDayhour = 8;
                        break;
                    case 2:
                        perDayhour = 4;
                        break;
                }
                int dailyWage = perDayhour * wagePerHour;
                 totalMonthlyWage += dailyWage;
            }
                        
            Console.WriteLine($"EmployeeWage of a month :{totalMonthlyWage}$");
        }
    }
}
