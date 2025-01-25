using Vehicle.Entities.Services;

namespace Vehicle.Entities.Enums.Vehicle
{
    /// <summary>
    /// Este Enum contém a lista de tipos disponíveis para os veículos.
    /// </summary>
    /// <remarks>
    /// Este Enum é utilizado pela classe <see cref="OrderVehicleService"/>
    /// para representar o tipo do veículo solicitado.
    /// </remarks>
    /// <seealso cref="OrderVehicleService"/>
    public enum Type
    {
        Motocicleta,
        Carreta,
        Bicicleta,
        Carro,
        Barco,
        Aeronave
    }
}