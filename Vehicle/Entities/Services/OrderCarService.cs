using Vehicle.Entities.Enums;

namespace Vehicle.Entities.Services
{
    /// <summary>
    /// Serviço responsável por processar a criação de um novo carro.
    /// </summary>
    /// <remarks>
    /// Este serviço é utilizado como parâmetro para criar um carro através da classe <see cref="Car"/>.
    /// </remarks>
    /// <example>
    /// Exemplo de uso:
    /// <code>
    /// OrderCarService service = new OrderCarService();
    /// service.SetManufacturer("Audi");
    /// service.SerModel("R8");
    /// service.SetColor(Color.Black);
    /// </code>
    /// </example>
    /// <seealso cref="Car"/>
    /// <seealso cref="Vehicle.Entities.Enums.Color"/>
    public class OrderCarService
    {
        // Propriedades que representam um veículo.

        /// <summary>
        /// Propriedade representando o fabricante do veículo.
        /// </summary>
        /// <value>
        /// O fabricante do veículo. Exemplo: "Honda", "Fiat". 
        /// </value>
        public string Manufacturer { get; private set; }

        /// <summary>
        /// Propriedade representando o modelo do veículo.
        /// </summary>
        /// <value>
        /// O modelo do veículo. Exemplo: "Civic", "Uno". 
        /// </value>
        public string Model { get; private set; }

        /// <summary>
        /// Propriedade representando a cor do veículo.
        /// </summary>
        /// <value>
        /// A cor do veículo. Exemplo: Color.Black, Color.White. 
        /// </value>
        public Color Color { get; private set; }

        /// <summary>
        /// Propriedade representando a placa do veículo, segundo o formato Mercosul.
        /// Exemplo: "BRA-1B23".
        /// </summary>
        /// <remarks>
        /// O valor desta propriedade é gerado automáticamente através do método <see cref="GeneratePlateService.Plate"/>
        /// </remarks>
        public string Plate { get; private set; } = GeneratePlateService.Plate();

        // Métodos utilizados para atribuir valores às propriedades do veículo.

        /// <summary>
        /// Método usado para atribuir um fabricante ao veículo.
        /// </summary>
        /// <param name="manufacturer">
        /// O fabricante do veículo. Exemplo: "Honda", "Fiat".
        /// </param>
        /// <remarks>
        /// Este método atribui um valor à propriedade <see cref="Manufacturer"/>
        /// </remarks>
        public void SetManufacturer(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        /// <summary>
        /// Método usado para atribuir um modelo ao veículo.
        /// </summary>
        /// <param name="model">
        /// O modelo do veículo. Exemplo: "Civic", "Uno".
        /// </param>
        /// <remarks>
        /// Este método atribui um valor à propriedade <see cref="Model"/>
        /// </remarks>
        public void SetModel(string model)
        {
            Model = model;
        }

        /// <summary>
        /// Método usado para atribuir uma cor ao veículo.
        /// </summary>
        /// <param name="color">
        /// A cor do veículo. Exemplo: Color.Black, Color.White.
        /// </param>
        /// <remarks>
        /// Este método atribui um valor à propriedade <see cref="Color"/>
        /// </remarks>
        /// <seealso cref="Vehicle.Entities.Enums.Color"/>
        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}