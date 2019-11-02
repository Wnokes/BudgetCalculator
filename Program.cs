using System;
using System.Collections.Generic;

namespace AmortizationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanEntity loan = LoanEntity.NewBuilder()
                .SetLoanName("Test Loan")
                .SetPrinciple(20000)
                .SetCurrentBalance(20000)
                .SetApr(.006155 * 12)
                .SetMinuminMonthlyPayment(415.76)
                .Build();

            Console.WriteLine("Expected length of loan paying minimum : " + new LoanTermCalculator()
                .GetMonthsUntilPaid(loan)
                .getMonthsUntilPaidOff());

            Dictionary<DateTime, double> payementChanges = new Dictionary<DateTime, double>
            {
                { DateTime.Now.AddMonths(5), 550.0 }
            };
            AmortiztionReport report = new AmortizationReportGenerator(new LoanTermCalculator(),
                                                                       new DateUtil()).GenerateReport(loan,
                                                                       payementChanges);
            new AmortizationReportConsolePrinter().PrintReport(report);
        }
    }
}
