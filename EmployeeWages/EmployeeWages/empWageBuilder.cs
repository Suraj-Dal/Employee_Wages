using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class empWageBuilder
    {
       int noOfCompany = 0;
       Employee[] emp = new Employee[5];
       
        public void addCompany(string company, int totalWorkingHrs, int totalWorkingDays, int wagesPerHour)
        {
            emp[this.noOfCompany] = new Employee(company, totalWorkingHrs, totalWorkingDays, wagesPerHour);
            noOfCompany++;
        }

        public void getWages()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                emp[i].getDetails(this.calculateWages(this.emp[i]));
                Console.WriteLine(emp[i].showDetails());
            }
        }
        private int calculateWages(Employee emp)
        {
            int workingHrs = 0, workingDays = 0, empHrs = 0, totalSalary;

            while (workingHrs <= emp.totalWorkingHrs && workingDays <= emp.totalWorkingDays)
            {
                workingDays++;
                Random random = new Random();
                int attendance = random.Next(0, 3);
                switch (attendance)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    case 0:
                        empHrs = 0;
                        break;
                }
                workingHrs += empHrs;
            }
            totalSalary = workingHrs * emp.wagesPerHour;
            return totalSalary;

        }

    }
}

