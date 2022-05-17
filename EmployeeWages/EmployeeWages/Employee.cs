using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        public void getAttendance()
        {
            int FullTime = 1;
            Random random = new Random();
            int attendance = random.Next(0, 2);

            if (attendance == FullTime)
                Console.WriteLine("Employee is present.");
            else
                Console.WriteLine("Employee is absent.");
        }
    }
}
