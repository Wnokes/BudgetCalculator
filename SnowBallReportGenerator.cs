using System;
using System.Collections.Generic;
using System.Linq;

namespace AmortizationCalculator
{
    class SnowBallReportGenerator
    {
        private readonly AmortizationReportGenerator AmortizationReportGenerator;
        private readonly AmortizationReportEvaluator AmortizationReportEvaluator;

        public SnowBallReportGenerator(AmortizationReportGenerator amortizationReportGenerator,
                                       AmortizationReportEvaluator amortizationReportEvaluator)
        {
            AmortizationReportGenerator = amortizationReportGenerator;
            AmortizationReportEvaluator = amortizationReportEvaluator;
        }

        public List<AmortizationReport> GenerateReport(List<LoanEntity> loans)
        {
            List<AmortizationReport> reports = new List<AmortizationReport>();

            List<LoanEntity> sortedLoans = loans.OrderBy(x => x.GetCurrentBalance()).ToList();

            double accumulatedAdditionalPayment = 0;
            DateTime previousLoanPayoffDate = DateTime.MinValue;
            foreach (LoanEntity loan in sortedLoans)
            {
                Dictionary<DateTime, double> paymentChanges = new Dictionary<DateTime, double>();

                if (previousLoanPayoffDate != DateTime.MinValue)
                {
                    paymentChanges.Add(previousLoanPayoffDate.AddMonths(1), loan.GetMinimumMonthlyPayment() + accumulatedAdditionalPayment);
                }

                AmortizationReport report = AmortizationReportGenerator.GenerateReport(loan, paymentChanges);

                reports.Add(report);
                previousLoanPayoffDate = AmortizationReportEvaluator.GetLoanPaidOffDateFromReport(report);
                accumulatedAdditionalPayment += loan.GetMinimumMonthlyPayment();
            }

            return reports;
        }
    }
}
