namespace DesignPattern.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Betala {amount} med kreditkort");
        }
    }
}
