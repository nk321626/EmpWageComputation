using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_FULL_TIME = 1;
        const int EMP_PART_TIME = 2;
        const int EMP_WAGE_PER_HR = 20;
        const int WORKING_DAYS_PER_MONTH = 20;
        static int daily_Emp_wage = 0;
        static int empHrs = 0;
        static int monthly_Emp_Wage = 0;
        static int monthly_Emp_hrs = 0;
        public static void GetMonthlyEmpWage()
        {
            Random random = new Random();
            for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)
            {
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case EMP_FULL_TIME:
                        empHrs = 8;
                        break;
                    case EMP_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                daily_Emp_wage = empHrs * EMP_WAGE_PER_HR;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} hrs", day , daily_Emp_wage, empHrs);
                monthly_Emp_Wage += daily_Emp_wage;
                monthly_Emp_hrs += empHrs;
            }
            Console.WriteLine("Monthly Employee Wage is: {0} for monthly working hours of {1}", monthly_Emp_Wage,monthly_Emp_hrs);
            
        }

    }
}


    

