using Vehicle.Entities.Enums.Global;

namespace Vehicle.Entities.Services
{
    /// <summary>
    /// Serviço responsável por processar a criação de um novo veículo.
    /// </summary>
    /// <remarks>
    /// Este serviço é utilizado como parâmetro para criar um veículo através da classe <see cref="Vehicle"/>.
    /// </remarks>
    /// <example>
    /// Exemplo de uso:
    /// <code>
    /// OrderVehicleService service = new OrderVehicleService();
    /// service.SetType("Carro");
    /// service.SetManufacturer("Audi");
    /// service.SerModel("R8");
    /// service.SetColor(Color.Black);
    /// </code>
    /// </example>
    /// <seealso cref="Vehicle"/>
    /// <seealso cref="Enums.Global.Color"/>
    public class OrderVehicleService
    {
        /// <summary>
        /// Propriedade representando o tipo do veículo.
        /// </summary>
        /// <value>
        /// O tipo do veículo. Exemplo: Tipo.Carro, Tipo.Moto; 
        /// </value>
        public Enums.Global.Type Type { get; private set; }

        /// <summary>
        /// Propriedade representando o fabricante do veículo.
        /// </summary>
        /// <value>
        /// O fabricante do veículo. Exemplo: "Honda", "Fiat". 
        /// </value>
        public string ? Manufacturer { get; private set; }

        /// <summary>
        /// Propriedade representando o modelo do veículo.
        /// </summary>
        /// <value>
        /// O modelo do veículo. Exemplo: "Civic", "Uno". 
        /// </value>
        public string ? Model { get; private set; }

        /// <summary>
        /// Propriedade representando a cor do veículo.
        /// </summary>
        /// <value>
        /// A cor do veículo. Exemplo: Color.Black, Color.White. 
        /// </value>
        public Color Color { get; private set; }

        // Métodos utilizados para atribuir valores às propriedades do veículo.
        
        /// <summary>
        /// Método usado para atribuir um tipo ao veículo.
        /// </summary>
        /// <param name="type">
        /// O fabricante do veículo. Exemplo: "Honda", "Fiat".
        /// </param>
        /// <remarks>
        /// Este método atribui um valor à propriedade <see cref="Type"/>
        /// </remarks>
        public void SetType(Enums.Global.Type type)
        {
            Type = type;
        }
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
        /// <seealso cref="Enums.Global.Color"/>
        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}