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
        int WagesPerHour = 20;
        public void getAttendance()
        {
            
            Random random = new Random();
            int attendance = random.Next(0, 2);

            if (attendance == FullTime)
            {
                Console.WriteLine("Employee is present.");
                int empHrs = 8;
                double salary = empHrs * WagesPerHour;
                Console.WriteLine("Employee salary for the day is: "+ salary);
            }
            else
                Console.WriteLine("Employee is absent.");
        }
    }
}
