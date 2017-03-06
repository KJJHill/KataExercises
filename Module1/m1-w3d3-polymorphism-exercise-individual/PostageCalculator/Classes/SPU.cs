using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{

    public class SPU : IDeliveryDriver
    {
        private int distance;

        public int Distance
        {
            get { return distance; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
        }

        private double rate;
        public double Rate
        {
            get { return rate; }
        }

        private string spuType;
        public string SPUType
        {
            get { return spuType; }
        }

        private string deliveryNameAndType;
        public string DeliveryNameAndType
        {
            get { return deliveryNameAndType; }
        }

        public SPU(int distance, double weight, string spuType)
        {
            if (distance > 0)
            {
                this.distance = distance;
            }
            else
            {
                this.distance = 0;
            }

            if (weight > 0)
            {
                this.weight = weight;
            }
            else
            {
                this.weight = 0;
            }

            if (spuType == "4-day")
            {
                this.spuType = spuType;
                deliveryNameAndType = "SPU (4-day ground)";
            }
            else if (spuType == "2-day")
            {
                this.spuType = spuType;
                deliveryNameAndType = "SPU (2-day business)";

            }
            else if (spuType == "Next-day")
            {
                this.spuType = spuType;
                deliveryNameAndType = "SPU (next-day)";
            }

        }

        public double CalculateRate(int distance, double weight)
        {
            if ((this.distance == distance) && (this.weight == weight))
            {
                if (spuType == "4-day")
                {
                    rate = Math.Round(((weight * 0.0050) * distance), 3, MidpointRounding.AwayFromZero);
                }
                else if (spuType == "2-day")
                {
                    rate = Math.Round(((weight * 0.050) * distance), 3, MidpointRounding.AwayFromZero);
                }
                else if (spuType == "Next-day")
                {
                    rate = Math.Round(((weight * 0.075) * distance), 3, MidpointRounding.AwayFromZero);
                }
            }

            if ((rate > 0) && (rate < 0.01))
            {
               rate = 0.01;
            }
            else
            {
               rate = Math.Round(rate, 2, MidpointRounding.AwayFromZero);
            }

            return rate;
        }

    }
}

