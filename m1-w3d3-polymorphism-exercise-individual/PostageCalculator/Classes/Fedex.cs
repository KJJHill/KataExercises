using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class Fedex : IDeliveryDriver
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

        private double rate = 20;
        public double Rate
        {
            get { return rate; }
        }

        private string deliveryNameAndType;
        public string DeliveryNameAndType
        {
            get { return deliveryNameAndType; }
        }

        public Fedex(int distance, double weight)
        {
            if (distance > 0 && distance <= 500)
            {
                this.distance = distance;
            }
            else if (distance > 0 && distance > 500)
            {
                this.distance = distance;
                rate += 5;
            }
            else
            {
                distance = 0;
            }

            if (weight > 0 && weight <= 48)
            {
                this.weight = weight;
            }
            else if (weight > 0 && weight > 48)
            {
                this.weight = weight;
                rate += 3;
            }
            else
            {
                this.weight = 0;
            }

            deliveryNameAndType = "FedEx";
        }

        public double CalculateRate(int distance, double weight)
        {
            double result = 0;
            if ((this.distance == distance) && (this.weight == weight))
            {
                result = Math.Round(rate, 2);
            }
            return result;
        }
    }
}
