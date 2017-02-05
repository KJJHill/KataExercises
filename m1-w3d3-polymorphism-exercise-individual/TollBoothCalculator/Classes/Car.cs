using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehichle
    {
        private bool hasTrailer;
        private int distance;
        private double toll;
        private string typeOfVehichle = "";

        public string TypeOfVehichle
        {
            get { return typeOfVehichle; }
        }

        public bool HasTrailer
        {
            get { return hasTrailer; }
        }

        public int Distance
        {
            get { return distance; }
        }

        public double Toll
        {
            get { return toll; }
        }

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
            typeOfVehichle = (hasTrailer) ? "Car with Trailer" : "Car without Trailer";
        }
        public double CalculateToll(int distance)
        {
            if (distance > 0)
            {
                this.distance = distance;
                toll = distance * 0.020;
                if (hasTrailer)
                {
                    toll += 1.00;
                }
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
