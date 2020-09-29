using System;

namespace Employee
{

    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0, day< NUM_OF_WORKING_DAYS, day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage + = empWage;
                Console.WriteLine("Emp Wage:" + empWage);
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }
    }
}