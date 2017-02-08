using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What directory is the file located in? ");
            string directory = Console.ReadLine();
            Console.Write("What is the name of the input file? ");
            string fileName = Console.ReadLine();
            Console.Write("How many lines of text (max) should there be in the split files? ");
            int fileLength = int.Parse(Console.ReadLine());
            int totalLinesInFile = 0;

            string fullPath = Path.Combine(directory, fileName);

            List<string[]> groupOfFiles = new List<string[]>();

            if (File.Exists(fullPath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        List<string> individualLine = new List<string>();

                        while (!sr.EndOfStream)
                        {
                            for (int i = 1; i <= fileLength; i++)
                            {
                                individualLine.Add(sr.ReadLine());
                            }
                            groupOfFiles.Add(individualLine.ToArray());

                        }
                        if (individualLine.Count() <= fileLength)
                        {
                            totalLinesInFile = individualLine.Count();
                        }
                    }
                    totalLinesInFile += (groupOfFiles.Count() * fileLength);
                    Console.WriteLine("The input file had " + totalLinesInFile + " lines of text.");
                    Console.ReadKey();
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            }
            try
            {
                string[] fileNameParts = fullPath.Split('.');
                for (int i = 1; i <= groupOfFiles.Count(); i++)
                {
                    string newFileName = fileNameParts[0] + "-" + i + "." + fileNameParts[1];
                    fullPath = Path.Combine(directory, newFileName);

                    using (StreamWriter sw = new StreamWriter(fullPath))
                    {
                        foreach (string line in groupOfFiles[i - 1])
                        {
                            sw.WriteLine(line);
                        }
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