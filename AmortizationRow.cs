using System;

namespace AmortizationCalculator
{
    class AmortizationRow
    {
        private int PaymentNumber;
        private double PaymentAmount;
        private double Interest;
        private double Principal;
        private double Balance;

        public AmortizationRow(int paymentNumber, double previousBalance, double interestRate, double paymentAmount)
        {
            Interest = previousBalance * interestRate;
            Principal = paymentAmount - Interest;
            Balance = previousBalance - Principal;

            PaymentNumber = paymentNumber;
            PaymentAmount = paymentAmount;
            Console.WriteLine(Balance);
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
