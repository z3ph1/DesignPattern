namespace DesignPattern.Strategy
{
    public class SwishPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Betala {amount} med Swish");
        }
    }
}
