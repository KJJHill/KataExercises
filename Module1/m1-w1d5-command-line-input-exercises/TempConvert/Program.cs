using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature: ");
            string temperatureString = Console.ReadLine();
            int digitalTemperature = int.Parse(temperatureString);
            int newTemperature = 0;

            Console.WriteLine("Is the temperature in (C)elcius, or (F)arenheit? ");
            string celciusOrFarenheit = Console.ReadLine();
            //if (celciusOrFarenheitString.Length > 1)
            //{
            //    Console.WriteLine("Please Enter Just the First Letter of Celcius or Farenheit: ");
            //    celciusOrFarenheitString = Console.ReadLine();
            //}

            
            if (celciusOrFarenheit[0] == 'F')
            {
                newTemperature = ((digitalTemperature - 32) * 5) / 9;
                Console.WriteLine(digitalTemperature + "F is "+ newTemperature + "C");
            }
            else if (celciusOrFarenheit[0] == 'C')
            {
                newTemperature = ((digitalTemperature * 9) / 5) + 32;
                Console.WriteLine(digitalTemperature + "C is " + newTemperature + "F");

            }


        }
    }
}
