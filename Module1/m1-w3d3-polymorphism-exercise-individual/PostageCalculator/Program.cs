using PostageCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();

            Console.Write("Please enter the weight of the package? ");
            double weight = Double.Parse(Console.ReadLine());
            Console.Write("(P)ounds or (O)unces? ");
            char weightType = Char.Parse(Console.ReadLine().ToLower());
            Console.Write("What distance will it be traveling? ");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine(weight.ToString("0.00"));

            if (weightType == 'p')
            {
                weight = weight * 16;
            }

            List<IDeliveryDriver> shippingOptions = new List<IDeliveryDriver>();
            shippingOptions.Add(new PostalService(distance, weight, "FirstClass"));
            shippingOptions.Add(new PostalService(distance, weight, "SecondClass"));
            shippingOptions.Add(new PostalService(distance, weight, "ThirdClass"));
            shippingOptions.Add(new Fedex(distance, weight));
            shippingOptions.Add(new SPU(distance, weight, "4-day"));
            shippingOptions.Add(new SPU(distance, weight, "2-day"));
            shippingOptions.Add(new SPU(distance, weight, "Next-day"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0, -28} {1,-25} \n", "Delivery Method", "$ Cost");
            Console.WriteLine("---------------------------------------------");

            foreach (IDeliveryDriver delieverydriver in shippingOptions)
            {
                Console.WriteLine("{0, -28} {1,-25:c} \n", delieverydriver.DeliveryNameAndType, delieverydriver.CalculateRate(distance, weight));
            }
            Console.ReadLine();

        }
    }
}
