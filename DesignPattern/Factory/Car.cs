namespace DesignPattern.Factory
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Kör en bil.");
        }
    }
}
