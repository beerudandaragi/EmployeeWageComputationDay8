using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDaily
{
    public class empWageDaily
    {
        public void compute()
        {


            const int Present = 1;
            const int Absent = 0;
            const int EmpWagePerHour = 80;
            int EmpHours = 0;
            int EmpDailyWage;

            Random rand = new Random();
            int randomvalue = rand.Next(0, 2);
            if (randomvalue == Present)
            {
                EmpHours = 8;

            }
            else if (randomvalue == Absent)
            {
                EmpHours = 0;

            }
            EmpDailyWage = EmpHours * EmpWagePerHour;
            Console.WriteLine("Employee Wage is " + EmpDailyWage);
            Console.ReadKey();
        }
        class Program
        {
            public static void Main(String[] args)
            {
                empWageDaily Empobj1 = new empWageDaily();
                Empobj1.compute();
            }
        }
    }
}