uusing System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            //Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee id Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}