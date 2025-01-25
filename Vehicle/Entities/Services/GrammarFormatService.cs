namespace Vehicle.Entities.Services
{
    /// <summary>
    /// Este serviço é responsável por formatar o gênero da frase segundo o sujeito.
    /// </summary>
    /// <remarks>
    /// Este serviço é utilizado na classe <see cref="MainMenu"/>.
    /// </remarks>>
    public static class GrammarFormatService
    {
        /// <summary>
        /// Este método retorna uma 'string' formatada com base no gênero do sujeito.
        /// </summary>
        /// <param name="s">Sujeito usado para formatar a frase.</param>
        /// <param name="f">Frase a ser formatada.</param>
        /// <returns>
        /// <example>
        /// Exemplo de uso:
        /// <code>
        /// Console.WriteLine(GrammarFormatService.GenreFormat("amigo da pedro", "pedro")); // Exibe "amigo do pedro".
        /// </code>
        /// </example>
        /// </returns>
        /// <seealso cref="MainMenu"/>
        public static string GenreFormat(string s, string f)
        {
            // Verifica se o sujeito é masculino ou feminino, formata e retorna a frase.
            if (s.EndsWith('a') || s.EndsWith('e'))
            {
                return f.Replace("do", "da");
            }
            return f;
        }
    }
}