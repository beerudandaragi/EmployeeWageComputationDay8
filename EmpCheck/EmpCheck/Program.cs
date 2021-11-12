using System;
using System.Collections.Generic;
using System.Text;

namespace EmpCheck
{
    class EmployeeWage
    {
    public void EmpWagecomputation()
        { 
             const int Is_Part_Time = 1;
             const int IS_FULLTIME = 2;
           const int EMP_RATE_PER_HOURS = 80;
            const int Num_Of_Working_days = 10;
                int emphrs = 0;
                int empwage = 0;
                int totalempwage = 0;
                for (int day = 0; day < Num_Of_Working_days; day++)
                {
                    Random random = new Random();
                    int empcheck = random.Next(0, 3);
                    switch (empcheck)
                    {
                        case Is_Part_Time:
                            emphrs = 4;
                            break;
                        case IS_FULLTIME:
                            emphrs = 8;
                            break;

                        default:
                            emphrs = 0;
                            break;
                    }

                    empwage = emphrs * EMP_RATE_PER_HOURS;
                    totalempwage += empwage;
                    Console.WriteLine("Emp Wage:" + empwage);
                }
                Console.WriteLine("Total Emp Wage:" + totalempwage);
                Console.ReadKey();
            }
        }
        class Program
        {
                    static void Main(string[] args)
            {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmpWagecomputation();
            }
        }
    }
        