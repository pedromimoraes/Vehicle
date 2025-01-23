using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;
using System.Text;

namespace Vehicle.Entities
{
    public class Vehicle(OrderVehicleService service)
    {
        public Enums.Type Type { get; private set; } = service.Type;
        public string Manufacturer { get; private set; } = service.Manufacturer;
        public string Model { get; private set; } = service.Model;
        public Color Color { get; private set; } = service.Color;

        /// <summary>
        /// Propriedade representando a placa do veículo, segundo o formato Mercosul.
        /// Exemplo: "BRA-1B23".
        /// </summary>
        /// <remarks>
        /// O valor desta propriedade é gerado automaticamente através do método <see cref="GeneratePlateService.Plate"/>
        /// </remarks>
        public string Plate { get; private set; } = GeneratePlateService.Plate();
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Tipo: {Type}");
            builder.AppendLine($"Fabricante: {Manufacturer}");
            builder.AppendLine($"Modelo: {Model}");
            builder.AppendLine($"Cor: {Color}");
            builder.AppendLine($"Placa: {Plate}");

            return builder.ToString();
        }
    }
}