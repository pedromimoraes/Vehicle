using Vehicle.Entities.Enums;

//TODO: Implementar o serviço GeneratePlateService para gerar placas quando um novo veículo for instanciado.

namespace Vehicle.Entities.Services
{
    public class OrderCarService
    {
        // Propriedades usadas para representar um veículo.
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public Color Color { get; private set; }

        public string Plate { get; private set; } = GeneratePlateService.Plate();
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