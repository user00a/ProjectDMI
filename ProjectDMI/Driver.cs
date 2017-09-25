using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDMI
{
    class Driver : Claims
    {
        private string driverName;
        private string driverOccupation;
        private DateTime driverDOB;
        Claims claims = new Claims();

        public Driver(string driverName, string driverOccupation, DateTime driverDOB)
        {
            this.driverName = driverName;
            this.driverOccupation = driverOccupation;
            this.driverDOB = driverDOB;
        }

        public void addClaimDate(DateTime newDate)
        {
            claims.AddToClaimDates(newDate);
        }

        public string Name
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public string Occupation
        {
            get { return driverOccupation; }
            set { driverOccupation = value; }
        }

        public DateTime DOB
        {
            get { return driverDOB;  }
            set { driverDOB = value; }
        }
    }
}
