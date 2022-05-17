using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        int FullTime = 1, PartTime = 2, WagesPerHour = 20, empHrs, empSalary;
        
        public int getAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 3);
            if (attendance == FullTime)
                Console.WriteLine("Employee is present.");
            
            else if (attendance == PartTime)
                Console.WriteLine("Employee present for part time.");
            
            else
                Console.WriteLine("Employee is absent.");
            return attendance;
        }

        public void calculateWages(int empCheck)
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
            Console.WriteLine("Employee salary for the day is: " + empSalary);
        }
    }
}
