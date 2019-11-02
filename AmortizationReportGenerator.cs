using System;
using System.Collections;
using System.Collections.Generic;

namespace AmortizationCalculator
{
    class AmortizationReportGenerator
    {
        readonly LoanTermCalculator LoanTermCalculator;
        readonly DateUtil DateUtil;

        public AmortizationReportGenerator(LoanTermCalculator loanTermCalculator, DateUtil dateUtil)
        {
            LoanTermCalculator = loanTermCalculator;
            DateUtil = dateUtil;
        }

        public AmortiztionReport GenerateReport(LoanEntity loan,
                                                Dictionary<DateTime, double> paymentChangesByDate)
        {

            int loanLength = LoanTermCalculator.GetMonthsUntilPaid(loan).getMonthsUntilPaidOff();
            ArrayList paymentDates = DateUtil.GetListOfDatesMonthApart(DateUtil.GetNow(), loanLength);

            AmortiztionReport report = new AmortiztionReport(loan);
            double balance = loan.GetCurrentBalance();
            foreach (DateTime date in paymentDates)
            {
                DateTime balanceEffectiveDate = DateUtil.FindDateBeforeFromList(date, new List<DateTime>(paymentChangesByDate.Keys));

                double paymentForDate = date == balanceEffectiveDate ? loan.GetMinimumMonthlyPayment() : paymentChangesByDate[balanceEffectiveDate] ;

                AmortizationRow row = new AmortizationRowGenerator()
                                            .GenerateRow(report.GetReportRows().Count + 1,
                                                         balance,
                                                         loan.GetMonthlyInterestRate(),
                                                         paymentForDate,
                                                         date);
                report.AddRow(row);
                balance = row.GetBalance();
            }
            return report;
        }
    }
}
