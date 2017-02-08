using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{

    public class Tank : IVehichle
    {
        private int distance;
        private double toll;
        private string typeOfVehichle = "Tank";

        public string TypeOfVehichle
        {
            get { return typeOfVehichle; }
        }
        public int Distance
        {
            get { return distance; }
        }

        public double Toll
        {
            get { return toll; }
        }

        public Tank()
        {
        }
        public double CalculateToll(int distance)
        {
            if (distance > 0)
            {
                this.distance = distance;
            }
            else
            {
                this.distance = 0;
            }

            toll = 0;
            return toll;
        }
    }
}
