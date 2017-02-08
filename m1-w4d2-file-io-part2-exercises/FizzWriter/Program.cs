using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "outputFizzBuzz.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    for (int i = 1; i <= 300; i++)
                    {
                        if (i % 3 == 0)
                        {
                            sw.Write("Fizz");
                        }
                        if (i % 5 == 0)
                        {
                            sw.Write("Buzz");
                        }
                        if((i % 3 != 0) && (i % 5 != 0))
                        {
                            sw.Write(i);
                        }
                        sw.WriteLine();

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error writing the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}
