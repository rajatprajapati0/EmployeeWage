using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int wagePerHour = 20;
        const int maxWorkingDay = 20;
        const int maxHour = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            int perDayhour = 0;
            int totalMonthlyWage = 0;
            int totalHour = 0;
            int totalDay = 0;
            Random rnd = new Random();

            while (totalDay < maxWorkingDay && totalHour<maxHour)
            for (int i = 0; i < maxWorkingDay; i++) 
            {
                    totalDay++;
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
                totalHour += perDayhour;
                int dailyWage = perDayhour * wagePerHour;
                totalMonthlyWage += dailyWage;
            }
                        
            Console.WriteLine($"EmployeeWage of a month :{totalMonthlyWage}$\ntotal day :{totalDay}\ntotal hour:{totalHour}");
        }
    }
}
