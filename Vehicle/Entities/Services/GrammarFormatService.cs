namespace Vehicle.Entities.Services
{
    public class GrammarFormatService
    {
        public static string GenreFormat(string p, string s)
        {
            if (p.EndsWith('a') || p.EndsWith('e'))
            {
                return s.Replace("do", "da");
            }
            else
            {
                return s;
            }
        }
    }
}