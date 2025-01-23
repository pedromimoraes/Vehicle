using Vehicle.Entities.Enums;

namespace Vehicle.Entities
{
    public class DefaultVehicle
    {
        public Enums.Type Type { get; private set; } = Enums.Type.Vazio;
        public string Manufacturer { get; private set; } = "Vazio";
        public string Model { get; private set; } = "Vazio";
        public Color Color { get; private set; } =  Color.Vazio;
        public string Plate { get; private set; } = "Vazio";
    }
}