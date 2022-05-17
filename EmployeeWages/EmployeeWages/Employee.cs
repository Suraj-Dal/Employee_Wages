using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        int FullTime = 1, PartTime = 2, WagesPerHour = 20, totalWorkingDays = 20, totalWorkingHrs = 100;
        int empHrs, empSalary, totalSalary;
        public int getAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);
            
            return attendance;
        }

        public void calculateWages(int empCheck)
        {
            int workingHrs = 0, workingDays = 0;
            while (workingHrs <= totalWorkingHrs && workingDays <= totalWorkingDays)
            {
                workingDays++;
                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }    
                workingHrs += empHrs;
            }
            totalSalary = workingHrs * WagesPerHour;
            Console.WriteLine("Total working hours of employee are: " + workingHrs);
            Console.WriteLine("Total working days of employee are: "+ workingDays);
            Console.WriteLine("Employee salary for Month is: " + totalSalary);
        }
    }
}
