namespace EmpWageComputation
{
    public class CompanyEmpWage
    {
        public int total_Emp_Wage;
        public int empWageperHr;
        public string company;
        public int empWagePerHr;
        public int workingDaysPerMonth;
        public int maxHrsPerMonth;
        internal int empRatePerHour;
        internal int nofoWorkingDays;

        public CompanyEmpWage(string company, int empWagePerHr, int workingDaysPerMonth, int maxHrsPerMonth)
        {
            this.company = company;
            this.empWagePerHr = empWagePerHr;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.total_Emp_Wage = totalEmpWage;
        }

        public string tostring()
        {
            return "Total Emp Wage for company : " + this.company + " is: " + this.total_Emp_Wage;
        }

    }
}