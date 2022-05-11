using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EmpWageComputation
{
    public class EmpWageBuilderList : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;



        private int numOfCompany = 0;
        private List<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyTotalWageMap;

        //private List<CompanyEmpWage> dailyAndTotalWageList;
        //private int dailyEmpWage;

        public EmpWageBuilderList()
        {
            companyEmpWageList = new List<CompanyEmpWage>();
            companyTotalWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWageToList(string company, int empWagePerHour, int workingDaysPerMonth, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empWagePerHour, workingDaysPerMonth, maxHoursPerMonth);
            companyEmpWageList.Add(companyEmpWage);
            companyTotalWageMap.Add(company, companyEmpWage);
        }




        public void computeEmpWage()
        {
            foreach (CompanyEmpWage empWage in companyEmpWageList)
            {
                empWage.setTotalEmpWage(computeEmpWage(empWage));
                Console.WriteLine(empWage.ToString());
            }
         
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.nofoWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                totalWorkingDays++;
                //CompanyEmpWage dailyAndTotalWage = new CompanyEmpWage(companyEmpWage.company, dailyEmpWage, companyEmpWage.total_Emp_Wage);

            }
            Console.WriteLine("Total Days: {0}, Total Working Hours: {1}", (totalWorkingDays - 1), totalEmpHrs);
            Console.WriteLine("Total Employee Wage for company " + companyEmpWage.company + " is: " + companyEmpWage.total_Emp_Wage + "\n");
            return companyEmpWage.total_Emp_Wage;
        }

         public int GetTotalWage(string company)
         {
            
            return this.companyTotalWageMap[company].total_Emp_Wage;
         }
    }
}