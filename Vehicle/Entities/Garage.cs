using System.Collections.Generic;

namespace Vehicle.Entities
{
    public class Garage
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
    }
}