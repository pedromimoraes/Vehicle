using Vehicle.Entities.Enums;

namespace Vehicle.Entities.Services
{
    public class OrderCarService
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public Color Color { get; private set; } 
        public void GetCarManufacturer(string manufacturer)
        {
            Manufacturer = manufacturer;
        }
        public void GetCarModel(string model)
        {
            Model = model;
        }
        public void GetCarColor(Color color)
        {
            Color = color;
        }
    }
}