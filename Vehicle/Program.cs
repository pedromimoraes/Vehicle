using Vehicle.Entities;
using Vehicle.Entities.Enums;
using Vehicle.Entities.Services;

// TODO: Criar lógica para definir o gênero das palavras no menu.
// TODO: Criar Enums personalizados de acordo com os fabricantes e guardá-los num dicionário.
// TODO: Polir o design do menu, organizando em classes.
// TODO: Implementar a classe 'Program'.
// TODO: Implementar um menu para interação com o programa.
// TODO: Avaliar a aplicação do try-catch no meu código.

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