using System;
using System.Collections.Generic;
using System.Text;

namespace EmpCheck
{
    class EmployeeWage
    {
        public void ComputeEmpWage()
        {
            const int Is_Part_Time = 1;
            const int IS_FULLTIME = 2;
            const int EMP_RATE_PER_HOURS = 80;
            const int Num_Of_Working_days = 10;
            const int Max_Hours_In_Month = 30;
            int EmpHours = 0, TotalEmpHours = 0, TotalWorkingDays = 0;
            while (TotalEmpHours <= Max_Hours_In_Month && TotalWorkingDays < Num_Of_Working_days)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                switch (Empcheck)
                {
                    case Is_Part_Time:
                        EmpHours = 8;
                        break;
                    case IS_FULLTIME:
                        EmpHours = 9;
                        break;

                    default:
                        EmpHours = 0;
                        break;
                }
                TotalEmpHours += EmpHours;
                Console.WriteLine("Days:" + TotalWorkingDays + "Emphrs:" + EmpHours);


            }
            int TotalEmpWage = TotalEmpHours * EMP_RATE_PER_HOURS;
            Console.WriteLine("Total Emp Wage:" + TotalEmpWage);
            Console.ReadKey();
        }
    }

    class program
    {
        public static void Main(string[] args)
        {
            EmployeeWage obj1 = new EmployeeWage();
            obj1.ComputeEmpWage();
        }

    }
}