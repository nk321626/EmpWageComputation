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
        const int MAX_HRS_PER_MONTH = 100;
        static int daily_Emp_wage = 0;
        static int empHrs = 0;
        static int total_Emp_Wage = 0;
        static int total_Emp_hrs = 0;
        static int day = 1;
        public static void GetMonthlyEmpWage()
        {
            Random random = new Random();
            while (day <= WORKING_DAYS_PER_MONTH && total_Emp_hrs <= MAX_HRS_PER_MONTH)
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
                total_Emp_Wage += daily_Emp_wage;
                total_Emp_hrs += empHrs;
                day++;
            }
            Console.WriteLine("Total Days: {0}, Total working hours:{1}",(day-1), total_Emp_hrs);
            Console.WriteLine("Total Employee Wage is: " + total_Emp_Wage);
            
        }

    }
}


    

