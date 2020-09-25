using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace TEams.Classes
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public string HireDate { get; set; }
        private double _startingSalary { get; set; }
        private string _FullName { get; set; }
        public string FullName { get
            {
                _FullName = ($"{LastName}, {FirstName}");
                return _FullName;
            }   
       
        
        }
        //public static double startingSalary
        //{
        //    get
        //    {
        //        _startingSalary = 60000;
        //        return _startingSalary;
        //    }
        //}
        const double startingSalary = 60000;


        public Employee(long employeeId, string firstName, string lastName, string email, Department department, string hireDate)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            HireDate = hireDate;
            Salary = startingSalary;
        }
        public Employee()
        {
            
        }
        public double RaiseSalary(double percent)
        {
            Salary = (Salary * percent / 100)+Salary;
            return Salary;
        }



    }
}
