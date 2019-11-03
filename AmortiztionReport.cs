using System.Collections;
using System.Collections.Generic;

namespace AmortizationCalculator
{
    public class AmortizationReport
    {
        private readonly List<AmortizationRow> ReportRows = new List<AmortizationRow>();
        private readonly LoanEntity Loan;

        public AmortizationReport(LoanEntity loan)
        {
            Loan = loan;
        }

        public void AddRow(AmortizationRow row)
        {
            ReportRows.Add(row);
        }

        public List<AmortizationRow> GetReportRows()
        {
            return ReportRows;
        }

        public LoanEntity GetLoan()
        {
            return Loan;
        }
    }
}
