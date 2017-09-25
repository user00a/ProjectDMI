using System;
using System.Collections.Generic;
using System.Windows;

namespace ProjectDMI
{
    class Policy : Driver
    {
        private DateTime policyStartDate;
        List<Driver> driverList = new List<Driver>();
        private int driverCount = 0;

        public Policy(string name, string occupation, DateTime dob) : base(name, occupation, dob)
        {
            MessageBox.Show("New policy made");
            AddDriver(name, occupation, dob);
        }

        public void AddDriver(string name, string occupation, DateTime dob)
        {
            if(driverCount < 5)
            {
                driverList.Add(new Driver(name, occupation, dob));
                driverCount++;
            }
            else
            {
                //
            }
        }

        public List<Driver> GetDrivers()
        {
            return driverList;
        }

        public DateTime StartDate
        {
            get { return policyStartDate; }
            set { policyStartDate = value; }
        }
    }
}
