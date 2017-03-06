using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            Console.Write("What word do you want to search for? ");
            string wordToSearchFor = Console.ReadLine();
            Console.Write("What directory file and path would you like to look for it in? ");
            string filepath = Console.ReadLine();
            Console.Write("Should the string be case insensitive? Please enter yes or no. ");
            string caseInsensitive = Console.ReadLine();
            
            int lineNumber = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        lineNumber++;

                        if (caseInsensitive == "yes")
                        {
                            line = line.ToLower();
                            wordToSearchFor = wordToSearchFor.ToLower();
                        }

                        if (line.Contains(wordToSearchFor))
                        {
                            Console.WriteLine(lineNumber + ") " + line);
                        }
                    } 
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
