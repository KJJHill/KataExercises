using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Product
    {
        // Class Code Goes Here
        private string name;
        private decimal price;
        private double weightInOunces;

        public double WeightInOunces
        {
            get { return weightInOunces; }
            set { weightInOunces = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
