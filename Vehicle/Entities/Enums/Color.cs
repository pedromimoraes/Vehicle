using Vehicle.Entities.Services;

namespace Vehicle.Entities.Enums
{
    /// <summary>
    /// Este Enum contém a lista de cores disponíveis para os veículos.
    /// </summary>
    /// <remarks>
    /// Este Enum é utilizado pela classe <see cref="OrderCarService"/>
    /// para representar a cor do veículo solicitado.
    /// </remarks>
    /// <seealso cref="OrderCarService"/>
    public enum Color : int
    {
        Vazio       = 0,
        Vermelho    = 1,
        Verde       = 2,
        Azul        = 3,
        Preto       = 4,
        Branco      = 5,
        Rosa        = 6,
        Cinza       = 7,
        Laranja     = 8
    }
}