namespace AmortizationCalculator
{
    class AmortizationReportGenerator
    {
        public AmortiztionReport GenerateReport(LoanEntity loan)
        {
            double balance = loan.GetCurrentBalance();
            AmortiztionReport report = new AmortiztionReport();
            while (balance > 0)
            {
                AmortizationRow row = new AmortizationRow(report.GetReportRows().Count,
                    balance,
                    loan.GetMonthlyInterestRate(),
                    loan.GetMinimumMonthlyPayment());
                report.AddRow(row);
                balance = row.GetBalance();
            }
            return report;
        }
    }
}
