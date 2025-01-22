using Vehicle.Entities.Services;

namespace Vehicle.Entities.Enums
{
/// <summary>
/// Este Enum contém a lista de cores disponíveis para os veículos.
/// Este Enum é utilizado pela classe <see cref="OrderCarService"/> para definir a cor do veículo solicitado.
/// </summary>
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
