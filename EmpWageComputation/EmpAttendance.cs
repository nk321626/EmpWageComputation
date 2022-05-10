using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_PRESENT = 1;

        public static void GetEmpAttendance()
        {
            Random random = new Random();
            int randomInput = random.Next(0, 2);

            if (randomInput == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
     
                int empHrs = 0;
                int empWage_Per_hr = 20;
                int EMP_FULL_TIME = 1;
                int EMP_PART_TIME = 0;
                randomInput = random.Next(0, 2);
                if (randomInput == EMP_FULL_TIME)
                {
                    empHrs = 8;
                    EMP_FULL_TIME = empHrs * empWage_Per_hr;
                    Console.WriteLine("Employee Full Time Wage is : " + EMP_FULL_TIME);


                }
                else if (randomInput == EMP_PART_TIME)
                {
                    empHrs = 4;
                    EMP_PART_TIME = empHrs * empWage_Per_hr;
                    Console.WriteLine("Employee Part Time Wage is : " + EMP_PART_TIME);
                }
                else
                {
                    //empHrs = 0;
                }


 
            }
            else
            {
                Console.WriteLine("Employe is Absent");
            }





        }
     }
}

    

