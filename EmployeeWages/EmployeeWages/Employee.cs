using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        public string company;
        public int totalSalary, totalWorkingHrs, totalWorkingDays, wagesPerHour;
        public Employee(string company, int totalWorkingHrs, int totalWorkingDays, int wagesPerHour)
        {
            this.company = company;
            this.totalWorkingDays = totalWorkingDays;
            this.totalWorkingHrs = totalWorkingHrs;
            this.wagesPerHour = wagesPerHour; 
        }

        public void getDetails(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public String showDetails()
        {
            return "Total Monthly Wages for "+ company + " is "+ totalSalary;
        }
        
    }
}

