using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService : IDeliveryDriver
    {

        private double rate;
        public double Rate
        {
            get { return rate; }
        }

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

        private string postalClassType;
        public string PostalClassType
        {
            get { return postalClassType; }
        }

        private int weightCategory;
        public int WeightCategory
        {
            get { return weightCategory; }
        }

        private string deliveryNameAndType;
        public string DeliveryNameAndType
        {
            get { return deliveryNameAndType; }
        }

        private Dictionary<int, double> firstClassRates = new Dictionary<int, double>
            { {0, 0.035 }, {1, 0.04 }, {2, 0.047 }, { 3, 0.195 }, {4, 0.45 }, {5, 0.5 }, };

        private Dictionary<int, double> secondClassRates = new Dictionary<int, double>
            { {0, 0.0035 }, {1, 0.004 }, {2, 0.0047 }, { 3, 0.0195 }, {4, 0.045 }, {5, 0.05 }, };

        private Dictionary<int, double> thirdClassRates = new Dictionary<int, double>
            { {0, 0.002 }, {1, 0.0022 }, {2, 0.0024 }, { 3, 0.015 }, {4, 0.016 }, {5, 0.017 }, };

        public PostalService(int distance, double weight, string postalClassType)
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
                SetWeightCategory(weight);
            }
            else
            {
                this.weight = 0;
            }

            if (postalClassType == "FirstClass")
            {
                this.postalClassType = postalClassType;
                deliveryNameAndType = "Postal Service (1st Class)";
            }
            else if (postalClassType == "SecondClass")
            {
                this.postalClassType = postalClassType;
                deliveryNameAndType = "Postal Service (2nd Class)";
            }
            else if (postalClassType == "ThirdClass")
            {
                this.postalClassType = postalClassType;
                deliveryNameAndType = "Postal Service (3rd Class)";
            }
        }

        public double CalculateRate(int distance, double weight)
        {
            double totalRatePrice = 0;

            if ((this.distance == distance) && (this.weight == weight))
            {
                if (postalClassType == "FirstClass")
                {
                    rate = firstClassRates[weightCategory];
                    totalRatePrice = Math.Round((distance * rate), 2, MidpointRounding.AwayFromZero);
                }
                else if (postalClassType == "SecondClass")
                {
                    rate = secondClassRates[weightCategory];
                    totalRatePrice = Math.Round((distance * rate), 3, MidpointRounding.AwayFromZero);
                }
                else if (postalClassType == "ThirdClass")
                {
                    rate = thirdClassRates[weightCategory];
                    totalRatePrice = Math.Round((distance * rate), 3, MidpointRounding.AwayFromZero);
                }
            }

            if ((totalRatePrice > 0) && (totalRatePrice < 0.01))
            {
                totalRatePrice = 0.01;
            }
            else
            {
                totalRatePrice = Math.Round(totalRatePrice, 2, MidpointRounding.AwayFromZero);
            }

            return totalRatePrice;

        }
        private void SetWeightCategory(double weight)
        {
            if (WeightIsInRange(weight, 0, 2))
            {
                weightCategory = 0;
            }
            else if (WeightIsInRange(weight, 3, 8))
            {
                weightCategory = 1;
            }
            else if (WeightIsInRange(weight, 9, 15))
            {
                weightCategory = 2;
            }
            else if (WeightIsInRange(weight, 16, 48))
            {
                weightCategory = 3;
            }
            else if (WeightIsInRange(weight, 49, 128))
            {
                weightCategory = 4;
            }
            else if (weight > 128)
            {
                weightCategory = 5;
            }
        }

        private bool WeightIsInRange(double weight, int mininum, int maximum)
        {
            bool results = (weight >= mininum && weight <= maximum) ? true : false;
            return results;
        }
    }
}
