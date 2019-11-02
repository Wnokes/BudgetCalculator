using System.Collections;

namespace AmortizationCalculator
{
    public class AmortiztionReport
    {
        private ArrayList ReportRows = new ArrayList();
        public void AddRow(AmortizationRow row)
        {
            ReportRows.Add(row);
        }

        public ArrayList GetReportRows()
        {
            return ReportRows;
        }
    }
}
