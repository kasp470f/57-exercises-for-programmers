using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            MakeEmployees(ref employees);
            Console.Write("Enter a search string:  ");
            string searchTerm = Console.ReadLine();
            searchTerm = char.ToUpper(searchTerm[0]) + searchTerm.Substring(1);
            var searchedFound = employees.Where(e => e.FName.Contains(searchTerm) || e.LName.Contains(searchTerm) == true);
            foreach (Employee e in searchedFound)
            {
                Console.WriteLine("{0} {1} {2} {3}", e.FName, e.LName, e.Position, e.SeparationDate);
            }
        }

        private static void MakeEmployees(ref List<Employee> employees)
        {
            employees.Add(new Employee("John", "Johnson", "Manager", "2016-12-31"));
            employees.Add(new Employee("Tou", "Xiong", "Software Engineer", "2016-10-05"));
            employees.Add(new Employee("Michaela", "Michaelson", "District Manager", "2015-12-19"));
            employees.Add(new Employee("Jake", "Jacobson", "Programmer", ""));
            employees.Add(new Employee("Jacquelyn", "Jackson", "DBA", ""));
            employees.Add(new Employee("Sally", "Weber", "Web Developer", "2015-12-18"));
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
