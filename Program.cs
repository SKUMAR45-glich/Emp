using System;

namespace Employee
{

    class Wage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
       
        public static void EmpWage(string company, int empRate, int numofDays, int maxHours)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHours && totalWorkingDays < numofDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Date: " + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRate;
            Console.WriteLine("Total Emp Wage of company " + company + " is " + totalEmpWage);
            //return totalEmpWage;

        }

    }
    class Program
    {

        public static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int rate = Convert.ToInt32(Console.ReadLine());
            int hour = Convert.ToInt32(Console.ReadLine());
            int days = Convert.ToInt32(Console.ReadLine());
            Wage empwage = new Wage();
            Wage.EmpWage(company, rate, days, hour);
        }
    }
}
