using Vehicle.Entities.Services;

namespace Vehicle.Entities.Enums.Vehicle
{
    /// <summary>
    /// Este Enum contém a lista de cores disponíveis para os veículos.
    /// </summary>
    /// <remarks>
    /// Este Enum é utilizado pela classe <see cref="OrderVehicleService"/>
    /// para representar a cor do veículo solicitado.
    /// </remarks>
    /// <seealso cref="OrderVehicleService"/>
    public enum Color
    {
        Red,
        Green,
        Blue,
        Black,
        White,
        Pink,
        Grey,
        Orange
    }
}