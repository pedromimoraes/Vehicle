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

            service.GetCarManufacturer("Audi");
            service.GetCarModel("R8");
            service.GetCarColor(Color.Black);

            Car car = new Car(service);
            
            Console.WriteLine(GeneratePlateService.Plate());
        }
    }
}