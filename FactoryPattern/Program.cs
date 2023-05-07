namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires does the vehicle have?");
            var tireNumber = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(tireNumber);
            vehicle.Drive();

        }
    }
}
