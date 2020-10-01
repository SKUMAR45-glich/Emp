using System;

namespace Employee
{

    class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private string company;
        private int empRatePerHour;
        private int numofWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuilder(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numofWorkingDays)
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
                Console.WriteLine("Date:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage of company"+company +"is" +totalEmpWage);

        }
        //{
        //Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");

        /*while (totalEmpHrs <= MAX_HRS_IN_NORTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
        {*/
        //Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        //}
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder abc = new EmpWageBuilder("abc", 10, 1, 10);
            EmpWageBuilder def = new EmpWageBuilder("abc", 20, 2, 0);
            abc.ComputeEmpWage();
            def.ComputeEmpWage();

        }
    }
}