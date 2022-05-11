//See https://aka.ms/new-console-template for more information
using EmpWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation Program\n");

EmpWageBuilderList empWageBuilder = new EmpWageBuilderList();
empWageBuilder.AddCompanyEmpWageToList("dell", 10, 4, 20);
empWageBuilder.AddCompanyEmpWageToList("HP", 20, 5, 20);
empWageBuilder.AddCompanyEmpWageToList("Lenovo", 30, 3, 30);
empWageBuilder.computeEmpWage();
Console.ReadLine();