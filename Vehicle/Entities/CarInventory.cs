using System.Collections.Generic;
using Vehicle.Entities;

namespace Vehicle.Entities
{
    public class CarInventory
    {
        public List<Car> Cars { get; private set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void DeleteCar(Car car)
        {
            Cars.Remove(car);
        }
        public Car GetCar(string plate)
        {
            return Cars.FirstOrDefault(car => car.Plate == plate);
        }
    }
}