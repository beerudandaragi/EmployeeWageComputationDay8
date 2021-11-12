using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpCheck
{
    class EmpWagee
    {
        public void compute()
        {
            const int Is_Part_Time = 1;
            const int IS_FULLTIME = 2;
            const int EMP_RATE_PER_HOURS = 300;
            int EmpHours = 0;
            int EmpDailyWage = 0;

            Random rand = new Random();

            int randomvalue = rand.Next(0, 3);

            switch (randomvalue)
            {
                case IS_FULLTIME:
                    EmpHours = 8;

                    break;
                case Is_Part_Time:
                    EmpHours = 4;

                    break;
                default:
                    EmpHours = 0;

                    break;
            }
            EmpDailyWage = EmpHours * EMP_RATE_PER_HOURS;
            Console.WriteLine("Employee Wage is " + EmpDailyWage);
            Console.ReadLine();
        }
    }
}
    

