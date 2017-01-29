using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {



        private int totalMarks;
        private int possibleMarks;
        private string submitterName;
        private string letterGrade;

        public int TotalMarks
        {
            get { return totalMarks; }
            set { totalMarks = value; }
        }

        public int PossibleMarks
        {
            get { return possibleMarks; }
        }

        public string SubmitterName
        {
            get { return submitterName; }
            set { submitterName = value; }
        }

        public string LetterGrade
        {
            get
            {

                if (possibleMarks > 0)
                {
                    if (totalMarks >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if (totalMarks > 80 && totalMarks < 89)
                    {
                        letterGrade = "B";
                    }
                    else if (totalMarks > 70 && totalMarks < 79)
                    {
                        letterGrade = "C";
                    }
                    else if (totalMarks > 60 && totalMarks < 69)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }
                }
                return letterGrade;
            }
        }


        public HomeworkAssignment(int possibleMarks)
        {
            this.possibleMarks = possibleMarks;
        }

    }
}
