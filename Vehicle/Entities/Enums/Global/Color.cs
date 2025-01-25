using Vehicle.Entities.Services;

namespace Vehicle.Entities.Enums.Global
{
    /// <summary>
    /// Este Enum contém a lista de cores disponíveis para os veículos.
    /// </summary>
    /// <remarks>
    /// Este Enum é utilizado pela classe <see cref="OrderVehicleService"/>
    /// para representar a cor do veículo solicitado.
    /// </remarks>
    /// <seealso cref="OrderVehicleService"/>
    public enum Color : int
    {
        Vermelho    = 0,
        Verde       = 1,
        Azul        = 2,
        Preto       = 3,
        Branco      = 4,
        Rosa        = 5,
        Cinza       = 6,
        Laranja     = 7
    }
}