using System;
using System.Collections.Generic;

namespace AmortizationCalculator
{
    public class AmortizationReportEvaluator
    {
        public DateTime GetLoanPaidOffDateFromReport(AmortizationReport report)
        {
            List<AmortizationRow> rows = report.GetReportRows();
            return rows[rows.Count - 1].GetPaymentDate();
        }

        public double GetAmountBeingPaidAtEndOfLoan(AmortizationReport report)
        {
            List<AmortizationRow> rows = report.GetReportRows();
            return rows[rows.Count - 1].GetPaymentAmount();
        }
    }
}
