using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        int FullTime = 1;
        int PartTime = 2;
        int WagesPerHour = 20;
        public void getAttendance()
        {
            
            Random random = new Random();
            int attendance = random.Next(0, 3);

            if (attendance == FullTime)
            {
                Console.WriteLine("Employee is present.");
                int empHrs = 8;
                double salary = empHrs * WagesPerHour;
                Console.WriteLine("Employee salary for the day is: "+ salary);
            }
            else if (attendance == PartTime)
            {
                Console.WriteLine("Employee present for part time.");
                int empHrs = 4;
                double salary = empHrs * WagesPerHour;
                Console.WriteLine("Employee salary for part time is: "+ salary);
            }
            else
                Console.WriteLine("Employee is absent.");
        }
    }
}
