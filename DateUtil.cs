using System;
using System.Collections;
using System.Collections.Generic;

namespace AmortizationCalculator
{
    public class DateUtil
    {
        public Dictionary<int, string> Months = new Dictionary<int, string>()
        {
            {1, "January" },
            {2, "Febuary" },
            {3, "March" },
            {4, "April" },
            {5, "May" },
            {6, "June" },
            {7, "July" },
            {8, "Augest" },
            {9, "September" },
            {10, "October" },
            {11, "Novemeber" },
            {12, "December" }
        };
        public DateTime GetNow()
        {
            return DateTime.Now;
        }

        public String GetCurrentMonthAsString()
        {
            return GetMonth(GetNow().Month);
        }

        public String GetMonth(int month)
        {
            return Months.GetValueOrDefault(month, "Unknown Month");
        }

        public ArrayList GetListOfDatesMonthApart(DateTime startDate, int numberOfDates)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < numberOfDates; i++)
            {
                list.Add(startDate.AddMonths(1));
            }

            return list;
        }
    }
}
