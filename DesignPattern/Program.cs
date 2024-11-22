using DesignPattern.Factory;
using DesignPattern.Singleton;
using DesignPattern.Strategy;

Thread t1 = new Thread(() =>
{
    var instance = Singleton.Instance(1);
});

Thread t2 = new Thread(() =>
{
    var instance = Singleton.Instance(2);
});

t1.Start();
t2.Start();


t1.Join();
t2.Join();

IPaymentStrategy strategy = new CreditCardPayment();
PaymentContext context = new PaymentContext(strategy);

context.ProcessPayment(5000);

IPaymentStrategy paypalStrategy = new PayPalPayment();
PaymentContext context2 = new PaymentContext(paypalStrategy);

context2.ProcessPayment(5000);

IPaymentStrategy swishStrategy = new SwishPayment();
PaymentContext context3 = new PaymentContext(swishStrategy);

context3.ProcessPayment(5000);

IVehicle car = VehicleFactory.CreateVehicle(VehicleType.Car);
car.Drive();

IVehicle motorcycle = VehicleFactory.CreateVehicle(VehicleType.Motorcycle);
motorcycle.Drive();

IVehicle truck = VehicleFactory.CreateVehicle(VehicleType.Truck);
truck.Drive();

Console.WriteLine("Hello, World!");
