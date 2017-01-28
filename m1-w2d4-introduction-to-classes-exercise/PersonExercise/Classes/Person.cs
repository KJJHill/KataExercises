using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        //Class Code Goes Here
        public string lastName;
        public string firstName;
        public int age;

        public string GetFullName()
        {
            return (firstName + " " + lastName);
        }

        public bool IsAdult()
        {
            bool result = (age >= 18) ? true : false;
            return result;
        }
    }
}
