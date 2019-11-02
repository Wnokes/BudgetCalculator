using System;

namespace AmortizationCalculator
{
    public class AmortizationReportConsolePrinter
    {
        public void PrintReport(AmortiztionReport report)
        {
            LoanEntity loan = report.GetLoan();
            Console.WriteLine("LOAN AT TIME OF REPORT");
            Console.WriteLine("".PadRight(20) +
                "PAYMENT AMOUNT".PadRight(20) +
                "INTEREST".PadRight(20) +
                "PRINCIPAL".PadRight(20) +
                "BALANCE".PadRight(20));

            Console.WriteLine("Initial".PadRight(20) + "".PadRight(20) + "".PadRight(20) + "".PadRight(20) + loan.GetCurrentBalance().ToString().PadRight(20));

            foreach (AmortizationRow row in report.GetReportRows())
            {
                Console.WriteLine(row.GetPaymentNumber().ToString().PadRight(20) +
                    row.GetPaymentAmount().ToString().PadRight(20) +
                    row.GetInterest().ToString().PadRight(20) +
                    row.GetPrincipal().ToString().PadRight(20) +
                    row.GetBalance().ToString().PadRight(20));
            }
        }
    }
}
