using System;

namespace EmployeeWage
{
    internal class Program
    {
        const int wagePerHour = 20;
    
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            Random rnd = new Random();
            int check=rnd.Next(0,3);
            int perDayhour = 0;

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
            Console.WriteLine($"Employee Per Day Wage :{dailyWage}$");

        }
    }
}
