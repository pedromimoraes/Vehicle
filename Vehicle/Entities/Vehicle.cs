using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;
using System.Text;

namespace Vehicle.Entities
{
    /// <summary>
    /// Esta classe é responsável por gerar veículos utilizando as propriedades fornecidas pelo serviço <see cref="OrderVehicleService"/>.
    /// </summary>
    /// <param name="service"></param>
    /// <seealso cref="OrderVehicleService"/>
    public class Vehicle(OrderVehicleService service)
    {
        /// <summary>
        /// Propriedade representando o tipo do veículo.
        /// </summary>
        /// <value>
        /// O tipo do veículo, fornecido pela propriedade Type do serviço <see cref="OrderVehicleService"/>
        /// </value>
        public Enums.Type Type { get; private set; } = service.Type;

        /// <summary>
        /// Propriedade representando o fabricante do veículo.
        /// </summary>
        /// <value>
        /// O tipo do veículo, fornecido pela propriedade Manufacturer do serviço <see cref="OrderVehicleService"/>
        /// </value>
        public string Manufacturer { get; private set; } = service.Manufacturer;

        /// <summary>
        /// Propriedade representando o modelo do veículo.
        /// </summary>
        /// <value>
        /// O tipo do veículo, fornecido pela propriedade Model do serviço <see cref="OrderVehicleService"/>
        /// </value>
        public string Model { get; private set; } = service.Model;

        /// <summary>
        /// Propriedade representando a cor do veículo.
        /// </summary>
        /// <value>
        /// O tipo do veículo, fornecido pela propriedade Color do serviço <see cref="OrderVehicleService"/>
        /// </value>
        public Color Color { get; private set; } = service.Color;

        /// <summary>
        /// Propriedade representando a placa do veículo, segundo o formato Mercosul.
        /// Exemplo: "BRA-1B23".
        /// </summary>
        /// <remarks>
        /// O valor desta propriedade é gerado automaticamente através do método <see cref="GeneratePlateService.Plate"/>
        /// </remarks>
        public string Plate { get; private set; } = GeneratePlateService.Plate();
        
        /// <summary>
        /// Este método constrói uma 'string' que é retornada ao utilizar o método 'Vehicle.ToString()'.
        /// </summary>
        /// <returns>
        /// Retorna uma 'string' contendo o Tipo, fabricante, modelo, cor e placa de um veículo.
        /// </returns>
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