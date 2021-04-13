using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Manager manager = new Manager() { Experience = 1, Name = "Михаил" };
            

            Console.WriteLine(company.Contains(manager));

            company += manager;

            Console.WriteLine(company.Contains(manager));

            Console.WriteLine(company.Employees[0].Name);


            company += new Manager() { Experience = 1, Name = "Никита" };
            company += new Worker() { Experience = 1, Name = "Олег" };
            company += new Worker() { Experience = 1, Name = "К" };
            company += new Foreman() { Experience = 1, Name = "Иван" };


            Console.WriteLine(company.GetMemberCount<Manager>());
            Console.WriteLine(company.GetMemberCount<Worker>());
            Console.WriteLine(company.GetMemberCount<Foreman>());


            List < Employee > managers = company.GetEmployees<Manager>();
            foreach (var item in managers)
            {
                Console.WriteLine(item.Name);
            }

            List<Employee> workers = company.GetEmployees<Worker>();
            foreach (var item in workers)
            {
                Console.WriteLine(item.Name);
            }

            List<Employee> foremans = company.GetEmployees<Foreman>();
            foreach (var item in foremans)
            {
                Console.WriteLine(item.Name);
            }

            company.DisplayMembers();

            Console.ReadKey();
        }
    }
}
