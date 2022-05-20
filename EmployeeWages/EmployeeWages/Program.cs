EmployeeWages.Employee Company1 = new EmployeeWages.Employee();
int empCheck = Company1.getAttendance();
Console.WriteLine("Employee wages in company 1:\n");
Company1.calculateWages(empCheck, 100, 20, 20);
Console.WriteLine("Employee wages in company 2:");
EmployeeWages.Employee Company2 = new EmployeeWages.Employee();
Company2.calculateWages(empCheck, 80, 15, 30);


