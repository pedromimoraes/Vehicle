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
    Red     = 0,
    Green   = 1,
    Blue    = 2,
    Black   = 3,
    White   = 4, 
    Pink    = 5
}
}
