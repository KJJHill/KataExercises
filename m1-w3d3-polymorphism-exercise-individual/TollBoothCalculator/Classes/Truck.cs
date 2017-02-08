using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{

    public class Truck : IVehichle
    {
        private int numberOfAxles;
        private int distance;
        private double toll;
        private double ratePerMile;
        private string typeOfVehichle = "";

        public string TypeOfVehichle
        {
            get { return typeOfVehichle; }
        }
        public double RatePerMile
        {
            get { return ratePerMile; }

        }

        public int NumberOfAxles
        {
            get { return numberOfAxles; }
        }

        public int Distance
        {
            get { return distance; }
        }

        public double Toll
        {
            get { return toll; }
        }

        public Truck(int numberOfAxles)
        {
            if (numberOfAxles > 0)
            {
                if (numberOfAxles == 4)
                {
                    this.numberOfAxles = numberOfAxles;
                    ratePerMile = 0.040;
                    typeOfVehichle = "Truck with 4 Axles";
                }
                else if (numberOfAxles == 6)
                {
                    this.numberOfAxles = 6;
                    ratePerMile = 0.045;
                    typeOfVehichle = "Truck with 6 Axles";
                }
                else if (numberOfAxles >= 8)
                {
                    this.numberOfAxles = 8;
                    ratePerMile = 0.048;
                    typeOfVehichle = "Truck with 8 Axles";
                }
            }
            else
            {
                numberOfAxles = 0;
            }
        }
        public double CalculateToll(int distance)
        {
            if (distance > 0)
            {
                this.distance = distance;
                toll = Math.Round((distance * ratePerMile), 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                this.distance = 0;
                toll = 0;
            }

            return toll;
        }

    }
}
