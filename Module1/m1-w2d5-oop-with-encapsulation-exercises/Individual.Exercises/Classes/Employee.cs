using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string fullName;
        private string department;
        private double annualSalary;

        public int EmployeeId
        {
            get { return employeeId; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FullName
        {
            get
            {
                fullName = lastName + ", " + firstName;
                return fullName;
            }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public double AnnualSalary
        {
            get { return annualSalary; }
        }

        public void RaiseSalary(double percent)
        {
            annualSalary = annualSalary * (1 + (percent / 100));
        }

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            annualSalary = salary;
        }
    }
}
