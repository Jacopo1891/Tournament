using System.Globalization;

namespace Tournament.Contracts.Commons.Messages
{

    public class ErrorMessages
    {
        private static TextInfo textFormatter = new CultureInfo("en-US", false).TextInfo;

        public static string EntityNotFound(string entity) => $"{textFormatter.ToTitleCase(entity)} not found.";
    }
}
