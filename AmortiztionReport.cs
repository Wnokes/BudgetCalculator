using System.Collections;

namespace AmortizationCalculator
{
    public class AmortiztionReport
    {
        private readonly ArrayList ReportRows = new ArrayList();
        private readonly LoanEntity Loan;

        public AmortiztionReport(LoanEntity loan)
        {
            Loan = loan;
        }

        public void AddRow(AmortizationRow row)
        {
            ReportRows.Add(row);
        }

        public ArrayList GetReportRows()
        {
            return ReportRows;
        }

        public LoanEntity GetLoan()
        {
            return Loan;
        }
    }
}
