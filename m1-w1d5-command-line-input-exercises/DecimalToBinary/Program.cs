using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces)");
            string message = Console.ReadLine();
            string[] decimalValues = message.Split(' ');

            for (int i = 0; i<decimalValues.Length; i++)
            {
                Console.WriteLine(decimalValues[i] + " in binary is " + Convert.ToString(int.Parse(decimalValues[i]), 2));
            }

        }
    }
}
