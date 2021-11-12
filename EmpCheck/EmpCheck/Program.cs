using System;
using System.Collections.Generic;
using System.Text;

namespace EmpCheck
{
    class program
    {
        public const int Is_Part_Time = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HOURS = 80;
        public const int Num_Of_Working_days = 20;
        public const int Max_Hours_In_Month = 100;

        public static int ComputeEmpWage()
        {
            int EmpHours = 0, TotalEmpHours = 0, TotalWorkingDays = 0;
            while (TotalEmpHours <= Max_Hours_In_Month && TotalWorkingDays < Num_Of_Working_days)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int Empcheck = random.Next(0, 3);
                switch (Empcheck)
                {
                    case Is_Part_Time:
                        EmpHours = 4;
                        break;
                    case IS_FULLTIME:
                        EmpHours = 8;
                        break;

                    default:
                        EmpHours = 0;
                        break;
                }
                TotalEmpHours += EmpHours;
                Console.WriteLine("Days:" + TotalWorkingDays + "Emphrs:" + EmpHours);
            }
            int TotalEmpwage = TotalEmpHours * EMP_RATE_PER_HOURS;
            Console.WriteLine("Total Emp Wage:" + TotalEmpwage);
            return TotalEmpwage;


        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
            Console.ReadLine();
        }


    }

}