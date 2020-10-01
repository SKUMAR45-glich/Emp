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
        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth, int totalEmpWage)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = totalEmpWage;
        }
    }
       
    class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList();
            arlist.Add(new CompanyEmpWage("abc", 101, 10, 13000,1200));
            arlist.Add(new CompanyEmpWage("def", 101, 10, 13000,1200));
            arlist.Add(new CompanyEmpWage("ghi", 101, 10, 13000,1200));
            arlist.Add(new CompanyEmpWage("fgh", 101, 10, 13000,1200));
            /*foreach (var item in arlist)
            {
                Console.Write(item + ", ");
            }*/
               
        }
    }
}