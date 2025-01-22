using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

namespace Vehicle.Entities
{

public class Car(OrderCarService service)
{
    public string Manufacturer {get; private set;} = service.Manufacturer;
    public string Model {get; private set;} = service.Model;
    public Color Color {get; private set;} = service.Color;
    public string Plate { get; private set; } = service.Plate;
}
}