using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TEams.Classes;

namespace TEams
{
    class Program
    {
        public static List<Department> departments = new List<Department>();
        public static List<Employee> employees = new List<Employee>();
        public static Dictionary<string, Project> projects = new Dictionary<string, Project>();

        static void Main(string[] args)
        {
            
            // create some departments
            CreateDepartments(001, "Marketing");
            CreateDepartments(002, "Sales");
            CreateDepartments(003, "Engineering");
            
            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();
            CreateEmployees(002, "Angie", "Smith", "asmith@teams.com", 60000, departments[2], "08/21/2020");
            CreateEmployees(003, "Margaret", "Thompson", "mthompson@teams.com", 60000, departments[0], "08/21/2020");
            employees[0].EmployeeId = 001;
            employees[0].FirstName = "Dean";
            employees[0].LastName = "Johnson";
            employees[0].Email = "djohnson@teams.com";
            employees[0].Salary = 60000;
            employees[0].Department = departments[2];
            employees[0].HireDate = "08/21/2020";

            // give Angie a 10% raise, she is doing a great job!
            employees[1].RaiseSalary(10);

            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject("TEams", "Project Management Software", "10/10/2020", "11/10/2020");

            // create the Marketing Landing Page Project
            CreateLandingPageProject("Marketing Landing Page", "Lead Capture Landing Page for Marketing", "10/10/2020", "10/17/2020");

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private static void CreateDepartments(int departmentId, string name)
        {
            Department department = new Department(departmentId, name);
            departments.Add(department);
        }

        /**
         * Print out each department in the collection.
         */
        private static void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            foreach(Department department in departments)
            {
                Console.WriteLine($"{department.Name}");
            }
            
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private static void CreateEmployees(int employeeId, string firstName, string lastName, string email, double salary, Department department, string hireDate)
        {
            Employee employee = new Employee(employeeId, firstName, lastName, email, department, hireDate);
            employees.Add(employee);
        }
        private static void CreateEmployees()
        {
            Employee employee = new Employee();
            employees.Add(employee);
        }

        /**
         * Print out each employee in the collection.
         */
        private static void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.FullName} ({employee.Salary}) {employee.Department}");
            }

        }

        /**
         * Create the 'TEams' project.
         */
        private static void CreateTeamsProject(string name, string description, string startDate, string dueDate)
        {
            for(int i = 0; i < employees.Count; i++)
            {
                
            }
        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private static void CreateLandingPageProject(string name, string description, string startDate, string dueDate)
        {

        }

        /**
         * Print out each project in the collection.
         */
        private static void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

        }
    }
}
