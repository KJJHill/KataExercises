using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{

    class Program
    {
        static void Main(string[] args)
        {

            List<IVehichle> myTollbooth = new List<IVehichle>()
            {
                { new Car(true) },
                { new Car(false) },
                { new Truck(4) },
                { new Truck(6) },
                { new Truck(8) },
                { new Tank()}

            };

            Random intRandomNum = new Random();
            int totalDistance = 0;
            double totalToll = 0;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.WriteLine("{0, -25} {1, 15} {2, 15}\n", "Vehichle", "Distance Traveled", "Toll");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (IVehichle vehichle in myTollbooth)
            {
                vehichle.CalculateToll(intRandomNum.Next(10, 240));
                Console.WriteLine("{0, -28} {1,5} {2,25:c}\n", vehichle.TypeOfVehichle, vehichle.Distance, vehichle.Toll);

                totalDistance += vehichle.Distance;
                totalToll += vehichle.CalculateToll(intRandomNum.Next(10, 240));
            }

            Console.WriteLine();
            Console.WriteLine("Total Distance: " + totalDistance);
            Console.WriteLine("Total Toll: {0:C} ", totalToll);
        }
    }
}
