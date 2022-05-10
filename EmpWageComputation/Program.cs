//See https://aka.ms/new-console-template for more information
using EmpWageComputation;

Console.WriteLine("Welcome to Employee Wage Computation Program\n");

EmpAttendance Dell = new EmpAttendance("Dell", 10, 4, 20);
Dell.GetMonthlyEmpWage();
Console.WriteLine("Dell".ToString());

EmpAttendance HP = new EmpAttendance("HP", 20, 5, 20);
HP.GetMonthlyEmpWage();
Console.WriteLine("HP".ToString());

EmpAttendance Lenovo = new EmpAttendance("Lenovo", 30, 3, 30);
Lenovo.GetMonthlyEmpWage();
Console.WriteLine("Lenovo".ToString());

Console.ReadLine();