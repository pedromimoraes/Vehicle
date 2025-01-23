using System.Collections.Generic;
using Vehicle.Entities;

namespace Vehicle.Entities
{
    public static class CarInventory
    {
        public static List<Car> Cars { get; private set; } = new List<Car>();

        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public static void DeleteCar(Car car)
        {
            Cars.Remove(car);
        }

        public static Car GetCar(string plate)
        {
            return Cars.FirstOrDefault(car => car.Plate == plate);
        }
    }
}