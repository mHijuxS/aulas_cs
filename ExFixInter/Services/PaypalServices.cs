

namespace ExFixInter.Services
{
    internal class PaypalServices : IOnlinePaymentService
    {
        private const double FeePercentage = .02;
        private const double MontlhyInterest = .01;

        public double Interest(double amount, int months)
        {
            return amount * MontlhyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
