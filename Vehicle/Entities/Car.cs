using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;
using System.Text;

namespace Vehicle.Entities
{
    public class Car(OrderCarService service)
    {
        public string Manufacturer { get; private set; } = service.Manufacturer;
        public string Model { get; private set; } = service.Model;
        public Color Color { get; private set; } = service.Color;
        public string Plate { get; private set; } = service.Plate;

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Fabricante: {Manufacturer}");
            builder.AppendLine($"Modelo: {Model}");
            builder.AppendLine($"Cor: {Color}");
            builder.AppendLine($"Placa: {Plate}");

            return builder.ToString();
        }
    }
}