using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectTest
{
    public static class CompanyExtensions
    {
        public static void DisplayMembers(this Company company)
        {
            foreach (var item in company.Employees)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static bool Contains(this Company company, Employee employee)
        {
            return company.Employees.Contains(employee);
        }
    }
}
