using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allWords = new List<string>();

            string fullpath = @"C:\test\QuizMaker.txt";
            bool fileExists = File.Exists(fullpath);
            string answer = "";
            string userAnswer = "";
            int totalCorrectAnswers = 0;
            int totalQuestions = 0;
            try
            {
                if (fileExists)
                {
                    using (StreamReader sr = new StreamReader(fullpath))
                    {

                        while (!sr.EndOfStream)
                        {

                            string line = sr.ReadLine();
                            totalQuestions++;

                            string[] quizQuestion = line.Split('|');

                            Console.WriteLine(quizQuestion[0]);
                            for (int i = 1; i < quizQuestion.Length; i++)
                            {
                                if (quizQuestion[i].Contains("*"))
                                {
                                    quizQuestion[i] = quizQuestion[i].Replace('*', ' ');
                                    answer = i.ToString();
                                }
                                Console.WriteLine(i + ") " + quizQuestion[i]);
                            }

                            Console.Write("Your Answer: ");
                            userAnswer = Console.ReadLine();
                      
                            if(userAnswer == answer)
                            {
                                Console.WriteLine("Right!");
                                totalCorrectAnswers++;
                            }
                            else
                            {
                                Console.WriteLine("Sorry that is incorrect.  The correct answer is: #" + answer);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("You got "+ totalCorrectAnswers+ " correct out of "+ totalQuestions + " total questions");
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
