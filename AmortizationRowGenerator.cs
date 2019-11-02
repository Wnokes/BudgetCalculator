using System;

namespace AmortizationCalculator
{
    public class AmortizationRowGenerator
    {
        public AmortizationRow GenerateRow(int paymentNumber,
                                           double previousBalance,
                                           double monthlyInterestRate,
                                           double paymentAmount,
                                           DateTime paymentDate)
        {
            double interestPayment = previousBalance * monthlyInterestRate;
            double principalPayment = paymentAmount - interestPayment;
            double newBalance = previousBalance - principalPayment;

            return AmortizationRow.NewBuilder()
                .WithPaymentNumber(paymentNumber)
                .WithPaymentDate(paymentDate)
                .WithPaymentAmount(paymentAmount)
                .WithInterestPayment(interestPayment)
                .WithPrincipal(principalPayment)
                .WithBalance(newBalance)
                .Build();
        }
    }
}
