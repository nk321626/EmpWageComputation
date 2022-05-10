using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        public const int EMP_FULL_TIME = 1;
        public const int EMP_PART_TIME = 2;

        //static int daily_Emp_wage = 0;
        //static int empHrs = 0;
        //static int total_Emp_Wage = 0;
        //static int total_Emp_hrs = 0;
        //static int day = 1;
        public static void GetMonthlyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            int empHrs = 0, total_Emp_Hrs = 0, total_Working_Days = 1, total_Emp_Wage = 0, daily_Emp_Wage = 0;
            Random random = new Random();
            while (total_Working_Days <= working_Days_Per_Month && total_Emp_Hrs <= max_Hrs_Per_Month )
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
                daily_Emp_Wage = empHrs * emp_Wage_Per_Hr;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", total_Working_Days, daily_Emp_Wage, empHrs);
                total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                total_Working_Days++;
            }
            Console.WriteLine("Total Days: {0}, Total working hours:{1}",(total_Working_Days-1), total_Emp_Hrs);
            Console.WriteLine("Total Employee Wage is: " + total_Emp_Wage + "\n");
            
        }

    }
}


    

