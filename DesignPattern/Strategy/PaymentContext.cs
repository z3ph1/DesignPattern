namespace DesignPattern.Strategy
{
    public class PaymentContext
    {
        public readonly IPaymentStrategy _paymentStrategy;
        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
