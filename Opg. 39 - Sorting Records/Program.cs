using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("John", "Johnson", "Manager", "2016-12-31"));
            employees.Add(new Employee("Tou", "Xiong", "Software Engineer", "2016-10-05"));
            employees.Add(new Employee("Michaela", "Michaelson", "District Manager", "2015-12-19"));
            employees.Add(new Employee("Jake", "Jacobson", "Programmer", ""));
            employees.Add(new Employee("Jacquelyn", "Jackson", "DBA", ""));
            employees.Add(new Employee("Sally", "Weber", "Web Developer", "2015-12-18"));

            var sortedlist = employees.OrderBy(x => x.LName);
            foreach (Employee employee in sortedlist)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", employee.FName, employee.LName, employee.Position, employee.SeparationDate);
            }
        }
    }

    public class Employee
    {
        public string FName;
        public string LName;
        public string Position;
        public string SeparationDate;

        public Employee(string fname, string lname, string position, string separationdate)
        {
            FName = fname;
            LName = lname;
            Position = position;
            SeparationDate = separationdate;
        }
    }
}
