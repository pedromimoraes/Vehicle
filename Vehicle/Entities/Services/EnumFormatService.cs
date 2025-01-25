using System.Text;

namespace Vehicle.Entities.Services
{
    public static class EnumFormatService
    {
        public static void Format(Enum e)
        {
            StringBuilder builder = new StringBuilder();
            string[] s = Enum.GetNames(e.GetType());

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    builder.Append($"{s[i]}, ");
                }
                else if (i == s.Length - 1)
                {
                    builder.Append($"{s[i].ToLower()}.");
                }
                else
                {
                    builder.Append($"{s[i].ToLower()}, ");
                }
            }
            System.Console.WriteLine(builder);
        }
    }
}