using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectTest
{
    public class Company
    {
        public List<Employee> Employees { get; }
        public int GetMemberCount<T>()
        {
            return Employees.Count(x => x is T);
        }

        public List<Employee> GetEmployees<T>()
        {
            return Employees.Where(x => x is T).ToList();
        }

        public Company()
        {
            Employees = new List<Employee>();
        }

        public static Company operator +(Company company, Employee employee)
        {
            company.Employees.Add(employee);
            return company;
        }

        public static Company operator -(Company company, Employee employee)
        {
            company.Employees.Remove(employee);
            return company;
        }
    }
}
