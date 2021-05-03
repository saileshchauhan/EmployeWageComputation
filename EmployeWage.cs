using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputation
{
    class EmployeWage
    {
        static void Main(string[] args)
        {
            //Constants
            int EMP_RATE_PER_HOUR = 20;
            int WORKING_DAY_PER_MONTH = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int day = 0;
            while (day <= WORKING_DAY_PER_MONTH && totalEmpHrs <= 100)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        day++;
                        empHrs = 4;
                        break;
                    case 2:
                        day++;
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                empWage = empHrs * EMP_RATE_PER_HOUR;
            }
            Console.WriteLine("ToTal work days " + day);
            Console.WriteLine("ToTal work Hours " + totalEmpHrs);
            Console.WriteLine("Total Emp Wage: " + empWage);
            Console.ReadKey();
        }
    }
}
