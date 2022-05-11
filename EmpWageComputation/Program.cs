//See https://aka.ms/new-console-template for more information
using EmpWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation Program\n");

EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();

empWageBuilder.addCompanyEmpWage("Dell", 20, 2, 10);
empWageBuilder.addCompanyEmpWage("HP", 10, 4, 20);
empWageBuilder.computeEmpWage();
Console.ReadLine();