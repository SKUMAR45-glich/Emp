//Exception 103

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace Employee
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company:" + this.company + "is" + this.totalEmpWage;
        }
    }

    public class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public int numofCompany = 0;
        private CompanyEmpWage[] companyEmpWages;
        public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            var arlist = new ArrayList();
            arlist.Add(new CompanyEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth));

            /*var arlist = new ArrayList();
            arlist.Add(new CompanyEmpWage("abc", 101, 10, 13000));
            arlist.Add(new CompanyEmpWage("def", 101, 10, 13000));
            arlist.Add(new CompanyEmpWage("ghi", 101, 10, 13000));
            arlist.Add(new CompanyEmpWage("fgh", 101, 10, 13000));*/
            numofCompany++;
        }

        public EmpWageBuilder()
        {
            this.companyEmpWages = new CompanyEmpWage[5];
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                companyEmpWages[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWages[i]));
                Console.WriteLine(this.companyEmpWages[i].toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numofWorkingDays)
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

            return totalEmpHrs * companyEmpWage.empRatePerHour;

        }
     
    }

    class Program
    {
        static void Main(string[] args)
        {
            //CompanyEmpWage companyEmpWage = new CompanyEmpWage();
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            
            empWageBuilder.addCompanyEmpWage("abc", 20, 2, 20);
            empWageBuilder.addCompanyEmpWage("def", 40, 1, 10);
            empWageBuilder.computeEmpWage();
        }
    }
}
