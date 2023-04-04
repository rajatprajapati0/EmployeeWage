using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int wagePerHour = 20;
        const int presentForFullDay = 1; 
        const int presentForHalflDay = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            Random rnd = new Random();
            int check=rnd.Next(0,3);
            int perDayhour = 0;

            if (check== presentForFullDay) 
            {
                perDayhour = 8;
            }
            else if (check == presentForHalflDay)
            {
                perDayhour = 4;
            }
            else 
            {
              perDayhour =0;    
            }
            int dailyWage = perDayhour * wagePerHour;
            Console.WriteLine($"Employee Per Day Wage :{dailyWage}$");

        }
    }
}
