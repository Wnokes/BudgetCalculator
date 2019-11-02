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
                list.Add(startDate.AddMonths(1 + i));
            }

            return list;
        }
        public DateTime FindDateBeforeFromList(DateTime targetDate, List<DateTime> dates)
        {
            dates.Sort((a, b) => a.CompareTo(b));

            if (dates.Count == 0 || targetDate < dates[0])
            {
                return targetDate;
            }
            else
            {
                if (dates.Count == 1)
                {
                    return dates[0] < targetDate ? dates[0] : targetDate;
                }
                else
                {
                    for (int i = 0; i < dates.Count; i++)
                    {
                        if (targetDate > dates[i] &&
                            targetDate < dates[i + 1])
                        {
                            return dates[i];
                        }
                    }
                }
            }
            return dates[dates.Count - 1];
        }
    }
}
