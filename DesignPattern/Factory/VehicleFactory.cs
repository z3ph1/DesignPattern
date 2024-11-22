namespace DesignPattern.Factory
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(VehicleType type)
        {
            IVehicle vehicle;

            switch (type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck();
                    break;
                default:
                    throw new ArgumentException("Ogiltig fordontyp");
            }

            return vehicle;
        }
    }
}
