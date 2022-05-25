using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class empWageBuilder
    {
       
        public void getWage()
        {
            Console.WriteLine("How many companies you want to add:");
            int noOfCompany = Convert.ToInt32(Console.ReadLine());
            while (noOfCompany > 0)
            {
                Employee emp = new Employee();
                int empCheck = emp.getAttendance();
                Console.WriteLine("Enter total Working Hours of Company:");
                int totalWorkingHrs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter total Working Days of Company:");
                int totalWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Wages Per Hour of Company:");
                int WagesPerHrs = Convert.ToInt32(Console.ReadLine());
                emp.calculateWages(empCheck, totalWorkingHrs, totalWorkingDays, WagesPerHrs);
                noOfCompany--;
            }
        }
    }
}
