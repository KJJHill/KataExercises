using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private string planeNumber;
        private int bookedFirstClassSeats;
        private int availableFirstClassSeats;
        private int totalFirstClassSeats;
        private int bookedCoachSeats;
        private int availableCoachSeats;
        private int totalCoachSeats;

        public string PlaneNumber
        {
            get { return planeNumber; }
        }
        public int BookedFirstClassSeats
        {
            get { return bookedFirstClassSeats; }
        }
        public int AvailableFirstClassSeats
        {
            get
            {
                availableFirstClassSeats = totalFirstClassSeats - bookedFirstClassSeats;
                return availableFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats
        {
            get { return totalFirstClassSeats; }
        }
        public int BookedCoachSeats
        {
            get { return bookedCoachSeats; }
        }
        public int AvailableCoachSeats
        {
            get
            {
                availableCoachSeats = totalCoachSeats - bookedCoachSeats;
                return availableCoachSeats;
            }
        }
        public int TotalCoachSeats
        {
            get { return totalCoachSeats; }
        }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalCoachSeats = totalCoachSeats;
            this.availableCoachSeats = totalCoachSeats;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.availableFirstClassSeats = totalFirstClassSeats;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool result = false;
            if (forFirstClass && (availableFirstClassSeats >= totalNumberOfSeats))
            {
                bookedFirstClassSeats += totalNumberOfSeats;
                availableFirstClassSeats -= totalNumberOfSeats;
                result = true;
            }
            else if ((!forFirstClass) && (availableCoachSeats >= totalNumberOfSeats))
            {
                bookedCoachSeats += totalNumberOfSeats;
                availableCoachSeats -= totalNumberOfSeats;
                result = true;
            }
            return result;
        }
    }
}
