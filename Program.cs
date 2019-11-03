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
            LoanEntity secondLoan = LoanEntity.NewBuilder()
                                              .SetLoanName("Test Loan")
                                              .SetPrinciple(5000)
                                              .SetCurrentBalance(5000)
                                              .SetApr(.006155 * 12)
                                              .SetMinuminMonthlyPayment(200)
                                              .Build();

            Console.WriteLine("Expected length of loan paying minimum : " + new LoanTermCalculator()
                .GetMonthsUntilPaid(loan)
                .getMonthsUntilPaidOff());

            Dictionary<DateTime, double> payementChanges = new Dictionary<DateTime, double>
            {
                //{ DateTime.Now.AddMonths(5), 550.0 }
            };

            AmortizationReportGenerator amortizationReportGenerator = new AmortizationReportGenerator(new LoanTermCalculator(),
                                                                                                      new DateUtil());

            AmortizationReport report = amortizationReportGenerator.GenerateReport(loan,
                                                                                  payementChanges);

            AmortizationReport secondReport = amortizationReportGenerator.GenerateReport(secondLoan,
                                                                                        payementChanges);
            AmortizationReportConsolePrinter printer = new AmortizationReportConsolePrinter();
            printer.PrintReport(report);
            printer.PrintReport(secondReport);

            SnowBallReportGenerator snowBallReportGenerator = new SnowBallReportGenerator(amortizationReportGenerator,
                                                                                          new AmortizationReportEvaluator());
            List<LoanEntity> loans = new List<LoanEntity> { loan, secondLoan };
            List<AmortizationReport> snowBallReports = snowBallReportGenerator.GenerateReport(loans);

            foreach(AmortizationReport snowReport in snowBallReports)
            {
                printer.PrintReport(snowReport);
            }
        }
    }
}
