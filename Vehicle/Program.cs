using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

namespace Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderCarService service = new OrderCarService();
            Car car = new Car(service);
            
            Console.WriteLine(car.Plate);
        }
    }
}