using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        int FullTime = 1, PartTime = 2, WagesPerHour = 20, WorkingDays = 20, empHrs, empSalary, totalSalary;
        
        public int getAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);
            
            return attendance;
        }

        public void calculateWages(int empCheck)
        {
            for (int i = 0; i < WorkingDays; i++)
            {
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
                empSalary = empHrs * WagesPerHour;
                totalSalary +=empSalary;
            }
            Console.WriteLine("Employee salary for Month is: " + totalSalary);
        }
    }
}
