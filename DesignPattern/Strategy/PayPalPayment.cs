namespace DesignPattern.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Betala {amount} med PayPal");
        }
    }
}
