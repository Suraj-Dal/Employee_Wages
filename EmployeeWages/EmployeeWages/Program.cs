using EmployeeWages;
namespace EmployeeWages
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            var log = NLog.LogManager.GetCurrentClassLogger();
            log.Info("Employee Wage calculator has started.\n");
            Console.WriteLine("How many Companies you want to add:");
            int noOfCompany = Convert.ToInt32(Console.ReadLine());
            empWageBuilder build = new empWageBuilder();

            while (noOfCompany > 0)
            {
                Console.WriteLine("Enter Name pf Company:");
                string company = Console.ReadLine();
                Console.WriteLine("Enter Total working Hours of company:");
                int totalWorkingHrs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter total Working Days of company:");
                int totalWorkingDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter wages per hour offered by company");
                int wagesPerHrs = Convert.ToInt32(Console.ReadLine());
                build.addCompany(company, totalWorkingHrs, totalWorkingDays, wagesPerHrs);
                noOfCompany--;
            }
            build.getWages();
        }

    }
}



































