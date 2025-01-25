using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Polir o design do menu, organizando em classes.
// TODO: Implementar um menu para interação com o programa.
// TODO: Implementar a classe 'Program'.
// TODO: Criar Enums personalizados de acordo com os fabricantes e guardá-los num dicionário.
// TODO: Avaliar a aplicação do try-catch no meu código.
// TODO : Traduzir o código para Inglês.

namespace Vehicle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(MainMenu.Show())
            {
                MainMenu.Show();

            }
        }
    }
}