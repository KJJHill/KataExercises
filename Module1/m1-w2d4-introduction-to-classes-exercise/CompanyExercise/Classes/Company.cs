using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {

        //        name string Holds the name of the company.
        //numberOfEmployees int Holds the number of employees.
        //revenue decimal Holds the company revenue.
        //expenses    decimal Holds the company expenses.
        //Methods

        //Method Name Return Type Description
        //GetCompanySize()    string A company is "small" if less than 50 employees,
        //"medium" if between 51 and 250 employees, "large" if greater than 250 employees
        //GetProfit() decimal Calculated by subtracting expenses from revenue.

        public string name;
        public int numberOfEmployees;
        public decimal revenue;
        public decimal expenses;


        public string GetCompanySize()
        {
            string result = "";
            if (numberOfEmployees < 50)
            {
                result = "small";
            }
            else if (numberOfEmployees >= 50 && numberOfEmployees < 250)
            {
                result = "medium";
            }
            else if (numberOfEmployees >= 250)
            {
                result = "large";
            }
            return result;
        }

        public decimal GetProfit()
        {
            decimal result = revenue - expenses;
            return result;
        }
    }
}
