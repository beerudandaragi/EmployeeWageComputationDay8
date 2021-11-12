using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagePartTime
{
    public class EmpPartTime
    {
        public void compute()
        {
            int Is_Part_Time = 1;
            int IS_FULLTIME = 2;

            int EmpWagePerHour = 200;
            int EmpHours = 0;
            int EmpDailyWage = 0;

            Random rand = new Random();
            int randomvalue = rand.Next(0, 3);
            if (randomvalue == IS_FULLTIME)
            {
                EmpHours = 8;

            }
            else if (randomvalue == Is_Part_Time)
            {
                EmpHours = 4;

            }
            else
            {
                EmpHours = 0;

            }
            EmpDailyWage = EmpHours * EmpWagePerHour;
            Console.WriteLine("Employee Wage is " + EmpDailyWage);
            Console.ReadKey();
        }
        class Program
        {
            public static void Main(string[] args)
            {
                EmpPartTime EmpObj1 = new EmpPartTime();
                EmpObj1.compute();

            }
        }
    }
}