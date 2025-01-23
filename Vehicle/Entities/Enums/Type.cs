using Vehicle.Entities.Services;

namespace Vehicle.Entities.Enums
{
    /// <summary>
    /// Este Enum contém a lista de tipos disponíveis para os veículos.
    /// </summary>
    /// <remarks>
    /// Este Enum é utilizado pela classe <see cref="OrderVehicleService"/>
    /// para representar o tipo do veículo solicitado.
    /// </remarks>
    /// <seealso cref="OrderVehicleService"/>
    public enum Type : int
    {
        Vazio       = 0,
        Moto        = 1,
        Carro       = 2,
        Aeronave    = 3
    }
}