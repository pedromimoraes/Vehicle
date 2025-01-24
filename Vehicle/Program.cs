using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Implementar a classe 'Program'.
// TODO: Implementar um menu para interação com o programa.
// TODO: Avaliar a aplicação do try-catch no meu código.

namespace Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (Entities.Enums.Color color in Enum.GetValues(typeof(Entities.Enums.Color)))
            {
                Console.Write($" {color}");
            }
        }
    }
}