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









































/*/--------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class CompanyEmpWage
    {
        public string company;
        public int empWagePerHour, empWorkDaysPerMonth, maxWorkingHours, totalSalary;

        public CompanyEmpWage(string company, int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.empWorkDaysPerMonth = empWorkDaysPerMonth;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setTotalEmpWage(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public string toString()
        {
            return "Monthly salary of an Employee in " + this.company + " is " + this.totalSalary;
        }
    }
}*/