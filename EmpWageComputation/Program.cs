//See https://aka.ms/new-console-template for more information
using EmpWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation Program\n");
Console.WriteLine("Dell");
EmpAttendance.GetMonthlyEmpWage("Dell", 20, 10, 5);
Console.WriteLine("HP");
EmpAttendance.GetMonthlyEmpWage("HP", 10, 20, 4);
Console.WriteLine("Lenovo");
EmpAttendance.GetMonthlyEmpWage("Lenovo", 15, 15, 3);
Console.ReadLine();