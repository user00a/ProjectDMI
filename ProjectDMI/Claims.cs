using System;
using System.Collections.Generic;

namespace ProjectDMI
{
    class Claims
    {
        List<DateTime> claimDates = new List<DateTime>();
        private int dateCount = 0;

        public void AddToClaimDates(DateTime date)
        {
            if (dateCount < 5)
            {
                claimDates.Add(date);
                dateCount++;
            }
            else
            {
                //
            }
        }

        public List<DateTime> GetClaimDates()
        {
            return claimDates;
        }
    }
}
